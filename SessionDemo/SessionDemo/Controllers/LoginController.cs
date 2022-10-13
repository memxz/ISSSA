using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SessionDemo.Controllers
{
    public class LoginController : Controller
    {
        private DB db;

        public LoginController(IConfiguration cfg)
        {
            db = new DB(cfg.GetConnectionString("db_conn"));
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login(IFormCollection form)
        {
            // data from client
            string username = form["username"];
            string password = form["password"];

            User user = db.GetUserByUsername(username);
            if (user != null) {
                // check if provided password matches the one in the database
                if (user.Password == password) {
                    // add a new session for this user who has login successfully
                    string sessionId = db.AddSession(user.Id);

                    // ask browser to save these cookies and send back next time
                    Response.Cookies.Append("SessionId", sessionId);

                    // send user to Home page
                    return RedirectToAction("Index", "Home");
                }
            }
            
            return RedirectToAction("Index", "Home");
        }
    }
}

