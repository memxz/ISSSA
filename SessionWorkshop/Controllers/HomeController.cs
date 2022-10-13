using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;
using System.Diagnostics;

namespace SessionWorkshop.Controllers
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
            // If username is inside the session, it means the
            // user has logged, therefore redirect her/him to 
            // the Track page
            if (HttpContext.Session.GetString("username") != null)
            {
                return RedirectToAction("Track", "Home");
            }

            // If code can reach this line, the user has not logged

            // If the username is NOT given, just reload the Login page
            if (string.IsNullOrEmpty(username))
                return View();

            // If code can reach this line, the username is given
            // Add the username and also the empty clicked info to the session
            HttpContext.Session.SetString("username", username);
            HttpContext.Session.SetString("clicked", "");

            // And redirect to the Track page
            return RedirectToAction("Track", "Home");
        }

        public IActionResult Track(string clickedBtn)
        {
            // Here, the controller checks if username is inside the session
            string? usernameInSession = HttpContext.Session.GetString("username");

            if (usernameInSession == null)
            {
                // No username is found in session, so the user needs to login
                return RedirectToAction("Login", "Home");
            }

            // User is clicking a new button, so controller needs to appends
            // this event into what has been stored in the session

            // Retrieve the clicked info from the session            
            string? clickedInSession = HttpContext.Session.GetString("clicked");
            // Add the new clicked button and store back to the session
            string newClicked = clickedInSession + " " + clickedBtn;
            HttpContext.Session.SetString("clicked", newClicked);

            // Here, the controller needs to retrieve the model data to send to view
            // for generating HTML
            // The data includes username and clicked buttons
            ViewData["username"] = HttpContext.Session.GetString("username");
            ViewData["clickedButtons"] = HttpContext.Session.GetString("clicked");

            return View();
        }

        public IActionResult Logout()
        {
            // User logs out, so clear the session and redirect to login page
            HttpContext.Session.Clear();
            // or HttpContext.Session.Remove("username");
            return RedirectToAction("Login", "Home");
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