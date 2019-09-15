using AutoMapper;
using JustEat.Services.Contracts;
using JustEat.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JustEat.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IMapper _mapper;

        public HomeController(IRestaurantService restaurantService, IMapper mapper)
        {
            _restaurantService = restaurantService;
            _mapper = mapper;
        }

        [HttpGet, Route]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, Route, ValidateAntiForgeryToken]
        public async Task<ActionResult> Index([Bind(Include = "Outcode")] RestaurantsViewModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var response = await _restaurantService.GetRestaurantsAsync(requestModel.Outcode);
                // happy path only for test
                if (!response.HasErrors)
                {
                    var responseModel = _mapper.Map<RestaurantsViewModel>(response);
                    responseModel.Restaurants = responseModel.Restaurants.OrderByDescending(r => r.RatingAverage);
                    return View(responseModel);
                }
            }

            return View(requestModel);
        }
    }
}