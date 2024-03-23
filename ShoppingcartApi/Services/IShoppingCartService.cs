using ShoppingcartApi.Models;

namespace ShoppingcartApi.Services
{
    public interface IShoppingCartService
    {
        List<Item> GetCartItems();
    }
}
