using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SessionDemo.Controllers
{
    public class LogoutController : Controller
    {
        private DB db;

        public LogoutController(IConfiguration cfg) 
        {
            db = new DB(cfg.GetConnectionString("db_conn"));
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (Request.Cookies["SessionId"] != null) {
                // remove our entry from database
                db.RemoveSession(Request.Cookies["SessionId"]);

                // ask client to remove its cookie so that it won't sent
                // it back next time
                Response.Cookies.Delete("SessionId");
            }

            return RedirectToAction("Index", "Login");
        }
    }
}

