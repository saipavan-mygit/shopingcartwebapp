using Moq;
using ShoppingcartApi.Controllers;
using ShoppingcartApi.Models;
using ShoppingcartApi.Services;
using Xunit;

namespace ShoppingcartApi.UnitTests
{
    public class ShoppingCartControllerTests
    {
        [Fact]
        public void GetCartItems_ReturnsItems()
        {
            //Arrange
            var mockIShoppingCartService = new Mock<IShoppingCartService>();
            List<Item> items = new List<Item> {
                new Item { ItemName = "A", ItemPrice = 50 },
                new Item { ItemName = "B", ItemPrice = 30 }
            };
            mockIShoppingCartService.Setup(serv => serv.GetCartItems()).Returns(items);

            //Act

            var controller = new ShoppingCartController(mockIShoppingCartService.Object);
            var resut = controller.GetCartItems();

            //Assert
            var resultType = Assert.IsType<object>(resut);
        }
    }
}
