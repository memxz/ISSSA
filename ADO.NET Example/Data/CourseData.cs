

using ADO.NET_Example.Models;
using Microsoft.Data.SqlClient;

namespace ADO.NET_Example.Data
{
    public class CourseData
    {
        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();

            string connectionString = @"Server=localhost;Database=adoWorkshop;User ID=sa;Password=root;encrypt=false"; /*Integrated Security=true"; */

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT ID, Code, Name,Description
                            FROM Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course()
                    {
                        ID = (int)reader["ID"],
                        Code = (string)reader["Code"],
                        Name = (string)reader["Name"]
                        Description = (string)reader["Description"]
                    };
                    courses.Add(course);
                }
            }

            return courses;
        }
    }
}
