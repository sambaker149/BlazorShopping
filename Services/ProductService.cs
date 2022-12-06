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
                Name = "Handball Spezial",
                Description = "Pantone, Collegiate Navy, Gum",
                Price = 80
            },
            new Product()
            {
                Id = 2,
                Name = "Galaxy 6",
                Description = "Core Black, Cloud White, Core Black",
                Price = 45
            },
            new Product()
            {
                Id = 3,
                Name = "Terrex Swift R3 Gore-Tex Hiking",
                Description = "Core Black, Core Black, Grey Six",
                Price = 140
            }
        };
    }
}