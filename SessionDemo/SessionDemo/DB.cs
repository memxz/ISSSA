using System.Data.SqlClient;

public class DB 
{
    private string connStr;

    public DB(string connStr) 
    {
        this.connStr = connStr;
    }

    public User GetUserBySession(string sessionId) 
    {
        User user = null;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"SELECT u.UserId, Username, Password
             FROM Session s, [User] u
                WHERE s.UserId = u.UserId AND 
                    s.SessionId = '{0}'", sessionId);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        user = new User {
                            Id = reader.GetGuid(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2)
                        };
                    }
                }
            }

            conn.Close();
        }

        return user;        
    }

    public User GetUserByUsername(string username)
    {
        User user = null;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"SELECT * FROM [User] 
                WHERE Username = '{0}'", username);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        user = new User {
                            Id = reader.GetGuid(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2)
                        };
                    }
                }
            }

            conn.Close();
        }

        return user;        
    }

    public string AddSession(Guid userId) 
    {
        string sessionId = null;        
        Guid guid = Guid.NewGuid();

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"INSERT INTO Session(
                SessionId, UserId, Timestamp) VALUES('{0}', '{1}', {2})", 
                    guid, userId, DateTimeOffset.Now.ToUnixTimeSeconds());                         

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                if (cmd.ExecuteNonQuery() == 1) {
                    sessionId = guid.ToString();
                }
            }

            conn.Close();            
        }

        return sessionId;
    }

    public bool RemoveSession(string sessionId)
    {
        bool status = false;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"DELETE FROM Session
                WHERE sessionId = '{0}'", sessionId);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                if (cmd.ExecuteNonQuery() == 1) {
                    status = true;
                }
            }

            conn.Close();            
        }

        return status;
    }
}