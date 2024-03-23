using Microsoft.AspNetCore.Mvc;
using ShoppingcartApi.Models;
using ShoppingcartApi.Services;

namespace ShoppingcartApi.Controllers
{
    [Route("api/[Controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public IActionResult GetCartItems()
        {
            var cartItems = new List<Item>();
            cartItems = _shoppingCartService.GetCartItems();
            return Ok(cartItems);
        }
    }
}
