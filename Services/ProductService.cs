using BlazorShopping.Models;

namespace BlazorShopping.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "P1",
                Description = "Example Product",
                Price = 70
            }
        };
    }
}
