using System;
using System.Threading.Tasks;

using R5T.Newport.Net;


namespace R5T.York.Newport
{
    public class NewtonsoftHttpJsonSource : IHttpJsonSource
    {
        public async Task<T> GetAsync<T>(string jsonUrlEndpoint)
        {
            var output = await HttpClientHelper.GetFromJsonAsync<T>(jsonUrlEndpoint);
            return output;
        }
    }
}
