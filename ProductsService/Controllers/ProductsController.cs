using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsService.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>
        {
        new Product { Id = 1, Name = "Product 1", Price = 10.0M },
        new Product { Id = 2, Name = "Product 2", Price = 20.0M }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
//        public IActionResult Index()
//        {
//            return View();
//        }
    }
}
