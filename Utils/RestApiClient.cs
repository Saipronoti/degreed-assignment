//using RestSharp;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace degreed_assignment.Utils
{
    public class RestApiClient
    {
         public async Task<string> GetRequest(string baseUrl, string endpoint, IList<Parameter> parameters, IDictionary<string, string> headers)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, HttpMethod.Get);

            if (parameters != null)
                foreach (var p in parameters) request.AddParameter(p);
                    request.AddHeaders(headers);

            var response = await client.ExecuteAsync(request);
            return response.Content;
        }
    }
}