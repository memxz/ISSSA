using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WsMiddleware.Models;

namespace WsMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private DB db;
        private ResponseTrackere tracker;
        public HomeController(IConfiguration cfg, ResponseTrackere tracker)
        {
            this.tracker = tracker;

            db = new DB(cfg.GetConnectionString("db_conn"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Stats()
        {
            double readTime=tracker.GetAvgReadTime();
            double writeTime=tracker.GetAvgWriteTime();
            ViewData["readTime"] = readTime;
            ViewData["writeTime"]=writeTime;
            return View();
        }
        public IActionResult Read()
        {
            ViewData["key"] = db.ReadMockData();
            return View();
        }
        public IActionResult Write()
        {
            ViewData["key"] = db.WriteMockData();
            return View();
        }
     

       
    }
}