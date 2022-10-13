using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetListUsers.Controllers;

public class UserController : Controller
{
    private IConfiguration cfg;

    public UserController(IConfiguration cfg)
    {
        this.cfg = cfg;
    }

    public IActionResult List(string searchStr)
    {
        if (searchStr == null)
        {
            searchStr = "";
        }

        List<Person> persons = new List<Person>();
        
        string db_conn = cfg.GetConnectionString("db_conn");

        using (SqlConnection conn = new SqlConnection(db_conn)) {
            conn.Open();
            string q = string.Format(@"SELECT * FROM Persons WHERE 
                FirstName LIKE '%{0}%' OR 
                LastName LIKE '%{1}%' OR 
                JobTitle LIKE '%{2}%'",
                    searchStr, searchStr, searchStr);

            using (SqlCommand cmd = new SqlCommand(q, conn)) {
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Person person = new Person {
                            Id = reader.GetGuid(0),
                            FirstName = reader.GetString(1),
                            LastName = reader.GetString(2),
                            JobTitle = reader.GetString(3),
                            YearsExperience = reader.GetInt32(4)
                        };

                        persons.Add(person);
                    }
                }
            }

            conn.Close();
        }
        ViewData["searchStr"] = searchStr;

        // pass data from controller to view
        ViewData["persons"] = persons;

        return View();
    }
}


