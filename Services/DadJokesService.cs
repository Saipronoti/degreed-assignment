
using RestSharp;
using degreed_assignment.Utils;
using degreed_assignment.Models;

public class DadJokesService{
     private readonly RestApiClient _restApiClient;
     private readonly AppSettings _appSettings;

     public DadJokesService(Options<AppSettings> appSettings,RestApiClient restApiClient)
        {
            _appSettings = appSettings.Value;
            _restApiClient = restApiClient;
        }

    public async Task<DadJokeResponseModel> GetRandomJoke()
        {
            
            var response = await _restApiClient.GetRequest(_appSettings.BaseUrl, _appSettings.ApiUrl, null,
                new Dictionary<string, string> { { "Accept", "application/json" } });

            return JsonConvert.DeserializeObject<DadJokeResponseModel>(response);
        }

        

}