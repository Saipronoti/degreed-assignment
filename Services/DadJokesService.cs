
using RestSharp;
using degreed_assignment.Utils;
using degreed_assignment.Models;

public class DadJokesService{
     private readonly AppSettings _appSettings;

    public async Task<DadJokeResponseModel> GetRandomJoke()
        {
            
            var client = new RestClient(_appSettings.BaseUrl);
            var request = new RestRequest(_appSettings.ApiUrl, Method.GET);

           

            var response = await client.ExecuteAsync(request);
            return response.Content;
        
            var response = await _restApiHelper.GetRequest(_appSettings.IchdjBaseUrl, _appSettings.IchdjRandomJokeEndpoint, null,
                new Dictionary<string, string> { { "Accept", "application/json" } });

            return JsonConvert.DeserializeObject<DadJokeResponseModel>(response);
        }

        

}