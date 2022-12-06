using BlazorShopping.Models;
using System.Collections.Immutable;

namespace BlazorShopping.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Product 1",
                Description = "Test Description 1",
                Price = 10
            },
            new Product()
            {
                Id = 2,
                Name = "Product 2",
                Description = "Test Description 2",
                Price = 20
            },
            new()
            {
                Id = 3,
                Name = "Product 3",
                Description = "Test Description 3",
                Price = 30
            }
        };
    }
}