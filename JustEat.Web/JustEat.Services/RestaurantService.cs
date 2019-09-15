using JustEat.Domain;
using JustEat.Rest.Contracts;
using JustEat.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestServiceClient _restServiceClient;

        public RestaurantService(IRestServiceClient restServiceClient)
        {
            _restServiceClient = restServiceClient;
        }

        public async Task<RestaurantResponse> GetRestaurantsAsync(string outcode)
        {
            return await _restServiceClient.GetItemAsync<RestaurantResponse>($"restaurants?q={outcode}");
        }
    }
}
