using MarketApp.Entities;
using MarketApp.Infrastructure;

namespace MarketApp.Services
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            return Database.Products;
        }

        public Product Get(int id)
        {
            return Database.Products.First(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            Database.Products.Add(product);
        }
    }
}
