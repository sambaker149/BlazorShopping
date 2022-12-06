using BlazorShopping.Models;

namespace BlazorShopping.Services
{
    public class BasketService
    {
        public static List<ShoppingItem> SelectedItems { get; set; } = new List<ShoppingItem>();

        public static void RemoveFromBasket(int productId)
        {
            SelectedItems.RemoveAll(x => x.Id == productId);
        }

        public void AddToBasket(int productId)
        {
            if (ProductInBasket(productId) is false)
            {
                var product = ProductService.Products.First(p => p.Id == productId);

                ShoppingItem item = new ShoppingItem();

                item.Product = product;
                item.PurchasePrice = product.Price;

                SelectedItems.Add(item);
            }
        }

        private bool ProductInBasket(int productId)
        {
            foreach (ShoppingItem item in SelectedItems)
            {
                if (item.Product.Id == productId)
                {
                    item.Quantity++;
                    return true;
                }
            }
            return false;
        }
    }
}