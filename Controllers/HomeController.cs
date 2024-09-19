using Microsoft.AspNetCore.Mvc;

namespace HomeworkMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }
    }
}
