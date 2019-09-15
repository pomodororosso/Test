using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustEat.Rest.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using JustEat.Rest;
using System.Net;

namespace JustEat.Services.Integration.Tests
{
    [TestClass]
    public class RestaurantServiceTests
    {
        private RestaurantService _restaurantService;
        private IRestServiceClient _restServiceClient;
        private HttpClient _httpClient;

        [TestMethod]
        public async Task GivenICallGetRestaurantsWithOutcodeSE19ThenAResponseWithNoErrorsIsReturned()
        {
            var response = await _restaurantService.GetRestaurantsAsync("SE19");
            Assert.IsFalse(response.HasErrors);
        }

        [TestInitialize]
        public void Initialise()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://public.je-apis.com/");
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            _httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Basic VGVjaFRlc3RBUEk6dXNlcjI=");
            _httpClient.DefaultRequestHeaders.Add("Host", "public.je-apis.com");


            _restServiceClient = new RestServiceClient(_httpClient);

            _restaurantService = new RestaurantService(_restServiceClient);
        }
    }
}
