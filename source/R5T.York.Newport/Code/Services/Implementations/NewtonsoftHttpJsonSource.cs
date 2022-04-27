using System;
using System.Threading.Tasks;

using R5T.Newport.Net;using R5T.T0064;


namespace R5T.York.Newport
{[ServiceImplementationMarker]
    public class NewtonsoftHttpJsonSource : IHttpJsonSource,IServiceImplementation
    {
        public async Task<T> GetAsync<T>(string jsonUrlEndpoint)
        {
            var output = await HttpClientHelper.GetFromJsonAsync<T>(jsonUrlEndpoint);
            return output;
        }
    }
}
