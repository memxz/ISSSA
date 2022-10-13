using System.Data.SqlClient;

public class DB {
    private string connStr;

    public DB(string connStr) 
    {
        this.connStr = connStr;
    }

    public string ReadMockData()
    {
        string key = null;

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"SELECT Top 1 [Key] FROM MockData
                ORDER BY CreateTimestamp DESC");

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    if (reader.Read()) {
                        key = reader.GetString(0);
                    }
                }
            }

            conn.Close();
        }

        return key;
    }

    public string WriteMockData()
    {
        Guid key = Guid.NewGuid();

        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();

            string q = String.Format(@"INSERT INTO MockData(
                Id, [Key], CreateTimestamp) VALUES('{0}', '{1}', {2})", 
                    Guid.NewGuid().ToString(), 
                    key, 
                    DateTimeOffset.Now.ToUnixTimeSeconds());                         

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                // one row should be added into the table
                cmd.ExecuteNonQuery();
            }

            conn.Close();            
        }

        return key.ToString();
    }
}