using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AvgResponseTime_net6.Models;


namespace AvgResponseTime_net6.Controllers;

public class HomeController : Controller
{
    private DB db;
    private ResponseTracker tracker;

    public HomeController(IConfiguration cfg, ResponseTracker tracker)
    {   
        this.tracker = tracker;        

        db = new DB(cfg.GetConnectionString("db_conn"));
    }

    public IActionResult Stats()
    {
        // double readDur = db.GetAvgLatency("/Home/Read");
        // double writeDur = db.GetAvgLatency("/Home/Write");

        double readDur = tracker.GetAvgReadTime();
        double writeDur = tracker.GetAvgWriteTime();        

        ViewData["read_dur"] = Math.Round(readDur, 3);
        ViewData["write_dur"] = Math.Round(writeDur, 3);

        return View();
    }

    public IActionResult Read()
    {
        ViewData["key"] = db.ReadMockData();

        return View();
    }

    public IActionResult Write()
    {
        // pass created random key to View for display
        ViewData["key"] = db.WriteMockData();      

        return View();
    }
}

