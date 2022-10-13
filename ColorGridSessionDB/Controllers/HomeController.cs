using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ColorGridSessionDB.Models;
using System.Text.Json;

namespace ColorGridSessionDB.Controllers;

public class HomeController : Controller
{
    private DB db;

    public HomeController(IConfiguration cfg)
    {
        db = new DB(cfg.GetConnectionString("db_conn"));
    }

    public IActionResult Index()
    {
        User user = GetUserBySession();
        if (user == null) {
            return RedirectToAction("Index", "Login");
        }
        
        ViewData["username"] = user.Username;
        return View();
    }

    public IActionResult SetNodeColor(string nodeId, string color) 
    {
        bool status = false;

        User user = GetUserBySession();
        if (user == null) {
            return RedirectToAction("Index", "Login");
        }

        if (nodeId != null && color != null) {
            status = db.SetNodeColor(nodeId, color, user.UserId);
        }
        
        return status ? Content("success") : Content("fail");
    }

    public IActionResult GetNodeColors()
    {
        User user = GetUserBySession();
        if (user == null) {
            return RedirectToAction("Index", "Login");
        }

        // .NET will convert our list into a JSON string for us
        List<Node> nodes = db.GetNodeColors(user.UserId);
        return Content(JsonSerializer.Serialize(nodes));
    }

    public User GetUserBySession() 
    {
        string sessionId = Request.Cookies["SessionId"];

        if (sessionId == null) {
            return null;
        }

        return db.GetUserBySession(sessionId);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

