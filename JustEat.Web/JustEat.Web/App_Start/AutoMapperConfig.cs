using AutoMapper;
using JustEat.Domain;
using JustEat.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustEat.Web.App_Start
{
    public class AutoMapperConfig
    {
        private static MapperConfiguration _mapperConfiguration = null;

        public static MapperConfiguration Configure()
        {
            if (_mapperConfiguration == null)
            {
                _mapperConfiguration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<AutoMapperProfile>();
                });
                _mapperConfiguration.AssertConfigurationIsValid();
            }

            return _mapperConfiguration;
        }
    }

    public class AutoMapperProfile : Profile
    {
        protected override void Configure()
        {
            CreateRestaurantMaps();
        }
        private void CreateRestaurantMaps()
        {
            CreateMap<RestaurantResponse, RestaurantsViewModel>()
                .ForMember(target => target.Outcode, options => options.MapFrom(source => source.ShortResultText));

            CreateMap<Restaurant, RestaurantViewModel>().
                ForMember(target => target.CuisineTypes, options => options.MapFrom(source => source.CuisineTypes.Select(c => c.Name)))
                .ForMember(target => target.LogoUrl, options => options.MapFrom(source => source.Logo != null && source.Logo.Any() ? source.Logo[0].StandardResolutionURL : ""));
        }
    }
}