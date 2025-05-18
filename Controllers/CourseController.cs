using Microsoft.AspNetCore.Mvc;

namespace Name
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult List()
        {
            return View();
        }
    }
}