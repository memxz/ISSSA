using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionDemo.Models;

namespace SessionDemo.Controllers;

public class HomeController : Controller
{
    private DB db;

    public HomeController(IConfiguration cfg)
    {
        db = new DB(cfg.GetConnectionString("db_conn"));
    }

    public IActionResult Index()
    {
        if (Request.Cookies["SessionId"] == null) {
            return RedirectToAction("Index", "Login");
        }

        User user = db.GetUserBySession(Request.Cookies["SessionId"]);
        if (user == null) {
            return RedirectToAction("Index", "Login");
        }

        ViewData["username"] = user.Username;
        
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

