using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using JustEat.Rest.Contracts;
using JustEat.Rest;
using JustEat.Services.Contracts;
using JustEat.Services;
using System.Net.Http;
using AutoMapper;

namespace JustEat.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterInstance<HttpClient>(CreateHttpClient());
            container.RegisterType<IRestServiceClient, RestServiceClient>();
            container.RegisterType<IRestaurantService, RestaurantService>();
            container.RegisterType<IMapper>(new InjectionFactory(i => AutoMapperConfig.Configure().CreateMapper()));
        }

        private static HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://public.je-apis.com/");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Accept-Tenant", "uk");
            httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-GB");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic VGVjaFRlc3RBUEk6dXNlcjI=");
            httpClient.DefaultRequestHeaders.Add("Host", "public.je-apis.com");
            return httpClient;
        }
    }
}
