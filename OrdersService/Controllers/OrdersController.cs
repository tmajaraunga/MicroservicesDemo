using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsService;

namespace OrdersService.Controllers
{
    public class OrdersController : Controller
    {
        private static List<Order> orders = new List<Order>
        {
            new Order
            {
                Id = 1,
                OrderDate = DateTime.Now,
                CustomerName = "John Doe",
                Products = new List<Product>
                {
                    new Product { Id = 1, Name = "Product 1", Price = 10.0M }
                }
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(orders);
        }
//        public IActionResult Index()
//        {
//            return View();
//        }
    }
}