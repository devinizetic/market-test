using MarketApp.Entities;
using MarketApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace MarketApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public void AddProduct(string name, int stock, decimal price, string category)
        {
            var product = new Product
            {
                Id = 1,
                Name = name,
                Stock = stock,
                Price = price,
                Category = category
            };

            var productService = new ProductService();
            productService.AddProduct(product);
        }
    }
}
