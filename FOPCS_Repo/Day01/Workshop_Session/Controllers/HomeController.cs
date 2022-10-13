using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Workshop_Session.Models;

namespace Workshop_Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(string username)
        {
            /**
             * b.	For a user who has already logged in and not yet logged out,
             * whenever he/she accesses this Login page, 
             * redirect him/her to the Track page
             */
            if (HttpContext.Session.GetString("Username") != null)
                return RedirectToAction("Track");
            /**
             * a.	Allow a user to login by providing any username
             * which should not be empty. No other checking is required
             * The web application stores the username into Session Object and redirect to the Track page. 
             */
            if (string.IsNullOrEmpty(username))
            {

                return View();
            }
            HttpContext.Session.SetString("Username", username);
            HttpContext.Session.SetString("click", "");
            return RedirectToAction("Track");

        }

        public IActionResult Track(string clickedBtn)
        {
            if (HttpContext.Session.GetString("Username") == null)
                return RedirectToAction("Login");
            //b.	Display the username previously stored in the Session Object.
            string username = HttpContext.Session.GetString("Username");

            ViewData["username"] = username;

            /**
             *  c.	Allow users to click any of the buttons 0, 1, 2 and store that information in the Session Object. 
             *  d.	Display the Click History accordingly.
             *  e.	Allow the user to log out by clearing the session data.
             *
             */

            string clickhistory = HttpContext.Session.GetString("click");
            string currentHistory = clickhistory + " " + clickedBtn;
            HttpContext.Session.SetString("click",currentHistory);
            ViewData["Click"]=currentHistory;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
            //return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}