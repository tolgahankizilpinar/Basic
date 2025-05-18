using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var crs = new Course();
            crs.Id = 1;
            crs.Title = "AspNet Core Course";
            crs.Description = "It is an useful course for me.";
            crs.Image = "1.jpg";

            return View(crs);
        }

         public IActionResult List()
        {
            var courses = new List<Course>()
            {
                new Course() {Id = 1, Title = "AspNet Course", Description = "Quality course.", Image = "1.jpg"},
                new Course() {Id = 2, Title = "Php Course", Description = "Quality course.", Image = "2.jpg"},
                new Course() {Id = 3, Title = "Django Course", Description = "Quality course.", Image = "3.jpg"},
                new Course() {Id = 4, Title = "Javascript Course", Description = "Quality course.", Image = "4.jpg"}
            };

            return View(courses);
        }
    }
}