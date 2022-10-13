using System.Xml.Linq;
using System;
using System.Data.SqlClient;
using DotNetCA.Models;

namespace DotNetCA
{
    public class DB
    {
        private string connStr;

        public DB(string connStr)
        {
            this.connStr = connStr;
        }
        //Get product list
        public List<Product> GetProductList()
        {
            List<Product>? productList = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string q = String.Format(@"SELECT * FROM Product p");

                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product pdt = new Product
                            {
                                productId = reader.GetInt32(0),
                                productName = reader.GetString(1),
                                ProductPrice = reader.GetDecimal(2),
                                productDesc = reader.GetString(3)
                            };
                            productList.Add(pdt);

                        }
                    }
                }

                conn.Close();
            }

            return productList;

        }
        //Get product detail
        public Product GetProductById(int id)
        {
            Product product = null;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string q = String.Format(@"SELECT productId, productName, productPrice,productDesc
                    FROM Product p
                    WHERE p.productId = '{0}'", id);

                using (SqlCommand cmd = new SqlCommand(q, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                productName = reader.GetString(1),
                                ProductPrice = reader.GetDecimal(2),
                                productDesc = reader.GetString(3)
                            };
                        }
                    }
                }

                conn.Close();
            }

            return product;

        }

        //public User GetUserBySession(string sessionId)
        //{
        //    User user = null;

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();

        //        string q = String.Format(@"SELECT u.UserId, Username, Password
        //     FROM Session s, [User] u
        //        WHERE s.UserId = u.UserId AND 
        //            s.SessionId = '{0}'", sessionId);

        //        using (SqlCommand cmd = new SqlCommand(q, conn))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    user = new User
        //                    {
        //                        UserId = reader.GetGuid(0),
        //                        Username = reader.GetString(1),
        //                        Password = reader.GetString(2)
        //                    };
        //                }
        //            }
        //        }

        //        conn.Close();
        //    }

        //    return user;
        //}

        //public User GetUserByUsername(string username)
        //{
        //    User user = null;

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();

        //        string q = String.Format(@"SELECT * FROM [User] 
        //        WHERE Username = '{0}'", username);

        //        using (SqlCommand cmd = new SqlCommand(q, conn))
        //        {
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    user = new User
        //                    {
        //                        UserId = reader.GetGuid(0),
        //                        Username = reader.GetString(1),
        //                        Password = reader.GetString(2)
        //                    };
        //                }
        //            }
        //        }

        //        conn.Close();
        //    }

        //    return user;
        //}

        //public string AddSession(Guid userId)
        //{
        //    string sessionId = null;
        //    Guid guid = Guid.NewGuid();

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();

        //        string q = String.Format(@"INSERT INTO Session(
        //        SessionId, UserId, Timestamp) VALUES('{0}', '{1}', {2})",
        //                guid, userId, DateTimeOffset.Now.ToUnixTimeSeconds());

        //        using (SqlCommand cmd = new SqlCommand(q, conn))
        //        {
        //            if (cmd.ExecuteNonQuery() == 1)
        //            {
        //                sessionId = guid.ToString();
        //            }
        //        }

        //        conn.Close();
        //    }

        //    return sessionId;
        //}

        //public bool RemoveSession(string sessionId)
        //{
        //    bool status = false;

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        conn.Open();

        //        string q = String.Format(@"DELETE FROM Session
        //        WHERE sessionId = '{0}'", sessionId);

        //        using (SqlCommand cmd = new SqlCommand(q, conn))
        //        {
        //            if (cmd.ExecuteNonQuery() == 1)
        //            {
        //                status = true;
        //            }
        //        }

        //        conn.Close();
        //    }

        //    return status;
        //}

    }
}
