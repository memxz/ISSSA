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
                            UserId = reader.GetGuid(0),
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
                            UserId = reader.GetGuid(0),
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

    public bool SetNodeColor(string nodeId, string color, Guid userId) 
    {
        if (UpdateNodeColor(nodeId, color, userId)) {
            return true;
        }

        return AddNodeColor(nodeId, color, userId);
    }

    public bool UpdateNodeColor(string nodeId, string color, Guid userId) 
    {
        bool status = false;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"UPDATE Node  
                SET Color = '{0}' 
                    WHERE NodeId = '{1}' AND UserId = '{2}'", 
                        color, nodeId, userId);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                if (cmd.ExecuteNonQuery() == 1) {
                    status = true;
                }
            }

            conn.Close();            
        }

        return status;
    }

    public bool AddNodeColor(string nodeId, string color, Guid userId)
    {
        bool status = false;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"INSERT INTO Node(Id, NodeId, Color, UserId)
                VALUES ('{0}', '{1}', '{2}', '{3}')", 
                    Guid.NewGuid(), nodeId, color, userId);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                if (cmd.ExecuteNonQuery() == 1) {
                    status = true;
                }
            }

            conn.Close();            
        }

        return status;
    }

    public List<Node> GetNodeColors(Guid userId) 
    {
        List<Node> nodes = new List<Node>();

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"SELECT NodeId, Color 
                FROM Node WHERE UserId = '{0}'", userId);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Node node = new Node {
                            NodeId = reader.GetString(0),
                            Color = reader.GetString(1)
                        };
                         
                        nodes.Add(node);
                    }
                }
            }

            conn.Close();
        }

        return nodes;        
    }
}