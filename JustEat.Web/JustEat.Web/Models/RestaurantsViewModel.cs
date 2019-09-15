using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JustEat.Web.Models
{
    public class RestaurantsViewModel
    {
        [Required, Display(Name="Outcode")]
        public string Outcode { get; set; }

        public IEnumerable<RestaurantViewModel> Restaurants { get; set; }
    }
}