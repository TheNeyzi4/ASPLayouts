using HomeworkMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkMVC.Controllers
{
    public class ProductsController : Controller
    {
        public static readonly List<Products> products = new List<Products> 
        { 
            new Products { Id=1, Name="Computer", Price=23000},
            new Products { Id=2, Name="Iphone 15", Price=35000},
            new Products { Id=3, Name="Redmi 12", Price=6500},
            new Products { Id=4, Name="Laptop", Price=55000},
            new Products { Id=5, Name="Keyboard", Price=3000},
        };


        public IActionResult Index()
        {
            ViewData["Title"] = "Products";
            return View(products);
        }
    }
}
