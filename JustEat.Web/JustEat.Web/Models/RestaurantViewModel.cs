using JustEat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustEat.Web.Models
{
    public class RestaurantViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float RatingAverage { get; set; }
        public IEnumerable<string> CuisineTypes { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string LogoUrl { get; set; }
        public string Description => $"{Name} | {RatingAverage} rating | {string.Join(", ", CuisineTypes)}"; 
    }
}
