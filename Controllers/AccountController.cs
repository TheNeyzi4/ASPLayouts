using Microsoft.AspNetCore.Mvc;

namespace HomeworkMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Account";
            return View();
        }
    }
}
