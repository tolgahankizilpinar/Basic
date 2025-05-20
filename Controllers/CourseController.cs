using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/Course/List");
            }
            var crs = Repository.GetById(id);
            return View(crs);
        }

         public IActionResult List()
        {       
            return View(Repository.Courses);
        }
    }
}