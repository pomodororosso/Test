using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustEat.Domain;
using System.Threading.Tasks;
using JustEat.Rest.Contracts;
using Moq;

namespace JustEat.Services.Tests
{
    [TestClass]
    public class RestaurantServiceTests
    {
        private RestaurantService _restaurantService;
        private Mock<IRestServiceClient> _mockRestServiceClient;

        [TestMethod]
        public async Task GivenICallGetRestaurantsWithAnOutcodeThenItIsPartOfTheRequest()
        {
            var outcode = "SE19";
            var response = await _restaurantService.GetRestaurantsAsync(outcode);

            _mockRestServiceClient.Verify(r => r.GetItemAsync<RestaurantResponse>($"restaurants?q={outcode}"), Times.Once);
        }

        [TestInitialize]
        public void Initialise()
        {
            _mockRestServiceClient = new Mock<IRestServiceClient>();
            _restaurantService = new RestaurantService(_mockRestServiceClient.Object);
        }
    }
}
