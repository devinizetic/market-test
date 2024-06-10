using MarketApp.Entities;

namespace MarketApp.Infrastructure
{
    public class Database
    {
        public static List<Product> Products { get; set; } = new List<Product>() {
        new 
        };
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public static List<Shop> Shops { get; set; } = new List<Shop>();
    }
}
