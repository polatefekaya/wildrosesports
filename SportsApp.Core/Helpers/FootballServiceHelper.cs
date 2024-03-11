using SportsApp.Core.HelperContracts;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using SportsApp.Core.ServiceContracts.Factories;

namespace SportsApp.Core.Helpers {
    public class FootballServiceHelper : IFootballServiceHelper {

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IConvertingHelper _convertingHelper;
        private readonly IRequestMessageFactory _requestMessageFactory;

        public FootballServiceHelper(IHttpClientFactory httpClientFactory, IConfiguration configuration, IConvertingHelper convertingHelper, IRequestMessageFactory requestMessageFactory) {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _convertingHelper = convertingHelper;
            _requestMessageFactory = requestMessageFactory;
        }

        public async Task<T?> HttpGetRequest<T>(string query) {
            using (HttpClient client = _httpClientFactory.CreateClient()) {
                HttpRequestMessage requestMessage = _requestMessageFactory.Create().SportsApi(_configuration["SportsAppToken"], query);

                HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

                return await _convertingHelper.ConvertResponseMessageToJson<T>(responseMessage);
            }
        }
    }
}
