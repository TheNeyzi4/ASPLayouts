using HomeworkMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkMVC.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> cart = new List<CartItem>();

        public IActionResult Index()
        {
            ViewData["Title"] = "Cart";
            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var products = ProductsController.products;

            var product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                var cartItem = cart.FirstOrDefault(c => c.ProductId == id);

                if (cartItem != null)
                {
                    cartItem.Quantity++;
                }
                else
                {
                    cart.Add(new CartItem
                    {
                        ProductId = product.Id,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = 1
                    });
                }
            }
            return RedirectToAction("Index");
        }
    }
}
