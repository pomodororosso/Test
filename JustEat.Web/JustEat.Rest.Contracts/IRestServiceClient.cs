using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Rest.Contracts
{
    public interface IRestServiceClient
    {
        Task<T> GetItemAsync<T>(string requestUri);
    }
}
