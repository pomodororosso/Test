using JustEat.Rest.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Rest
{
    public class RestServiceClient : IRestServiceClient
    {
        private readonly HttpClient _httpClient;

        public RestServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> GetItemAsync<T>(string requestUri)
        {
            var response = await _httpClient.GetAsync(requestUri);
            return await response.Content.ReadAsAsync<T>();
        }        
    }
}
