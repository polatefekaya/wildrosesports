using SportsApp.Core.HelperContracts;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace SportsApp.Core.Helpers {
    public class FootballServiceHelper : IFootballServiceHelper {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IConvertingHelper _convertingHelper;

        public FootballServiceHelper(IHttpClientFactory httpClientFactory, IConfiguration configuration, IConvertingHelper convertingHelper) {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _convertingHelper = convertingHelper;
        }

        public async Task<T?> HttpGetRequest<T>(string uri) {
            using (HttpClient client = _httpClientFactory.CreateClient()) {
                HttpRequestMessage requestMessage = new HttpRequestMessage() { 
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(uri),
                    Headers = {
                        { "x-rapidapi-host", "v3.football.api-sports.io"},
                        { "x-rapidapi-key", _configuration["SportsAppToken"] }
                    }
                };

                HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

                return await _convertingHelper.ConvertResponseMessageToJson<T>(responseMessage);
            }
        }
    }
}
