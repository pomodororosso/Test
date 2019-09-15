using JustEat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Services.Contracts
{
    public interface IRestaurantService
    {
        Task<RestaurantResponse> GetRestaurantsAsync(string outcode);
    }
}
