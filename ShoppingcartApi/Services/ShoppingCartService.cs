using ShoppingcartApi.Models;

namespace ShoppingcartApi.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly Dictionary<string, decimal> cartItems = new Dictionary<string, decimal>()
        {
            {"A",50 },
            {"B",30 },
            {"C",20 },
            {"D",15 },
        };
        public List<Item> GetCartItems()
        {
            var items = new List<Item>();
            foreach(var item in cartItems)
            {
                items.Add(new Item { ItemName = item.Key, ItemPrice = item.Value });
                
            }
            return items;
        }
    }
}
