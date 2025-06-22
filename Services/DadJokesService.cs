

public class DadJokesService{
     private readonly AppSettings _appSettings;

    public async Task<DadJokeResponseModel> GetRandomJoke()
        {
            
            var client = new RestClient(_appSettings.IchdjBaseUrl);
            var request = new RestRequest(_appSettings.IchdjRandomJokeEndpoint, Method.GET);

            if (parameters != null)
                foreach (var p in parameters) request.AddParameter(p);
                    request.AddHeaders(headers);

            var response = await client.ExecuteAsync(request);
            return response.Content;
        
            var response = await _restApiHelper.GetRequest(_appSettings.IchdjBaseUrl, _appSettings.IchdjRandomJokeEndpoint, null,
                new Dictionary<string, string> { { "Accept", "application/json" } });

            return JsonConvert.DeserializeObject<DadJokeResponseModel>(response);
        }

}