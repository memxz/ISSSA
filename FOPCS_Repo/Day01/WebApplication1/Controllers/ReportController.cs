using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ReportController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult testView(MessageViewModel mvm)
        {
            ViewData["Message"] = "This is the message from Controller ";

            return View(mvm);
        }
        public IActionResult Message()
        {
            MessageViewModel model = new MessageViewModel
            {
                Message = "Hello View",
                From = "Controller Message action"
            };

            return View(model);
        }

    }
}




