using ADO.NET_Example.Data;
using ADO.NET_Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADO.NET_Example.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            List<Course> courses = CourseData.GetAllCourses();
            ViewData["courses"] = courses;

            return View();
        }

        public IActionResult CourseDetails() 
        { 
            Course course = new Course();
        }
    }
}
