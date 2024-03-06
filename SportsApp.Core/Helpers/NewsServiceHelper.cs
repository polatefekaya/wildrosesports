using SportsApp.Core.HelperContracts;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Helpers {
    public class NewsServiceHelper : INewsServiceHelper {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IConvertingHelper _convertingHelper;

        public NewsServiceHelper(IHttpClientFactory httpClientFactory, IConfiguration configuration, IConvertingHelper convertingHelper) {
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
                        {"X-Api-Key", _configuration["NewsToken"]},
                        {"User-Agent", "SportsApp/0.1"}
                    }
                };
                
                HttpResponseMessage responseMessage = await client.SendAsync(requestMessage);

                return await _convertingHelper.ConvertResponseMessageToJson<T>(responseMessage);
            }
        }
    }
}
