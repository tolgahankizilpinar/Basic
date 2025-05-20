using Basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(Repository.Courses);
    }

    public IActionResult Contact()
    {
        return View();
    }


}
