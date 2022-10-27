using DigiShop.Infrastructure;
using DigiShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigiShop.Controllers
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

            /*if (Request.Cookies["SessionId"] == null)
            {
                return RedirectToAction("Index", "Product");
            }

           // User user = db.GetUserBySession(Request.Cookies["SessionId"]);
            if (user == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewData["username"] = user.Username;*/

            return View();
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