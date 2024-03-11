using SportsApp.Core.ServiceContracts.Factories;
using System;
using System.Collections.Generic;


namespace SportsApp.Core.Services.Factories {
    public class RequestMessageFactory : IRequestMessageFactory {

        public RequestMessageFactory Create() {
            return this;
        }

        //TODO: create builder method, don't receive a query, instead of query, accept SportsApiRequest object and transform it to the query automatically

        public HttpRequestMessage SportsApi(string? key, string query) {
            if(key == null) throw new ArgumentNullException("given key is null");

            string baseUrl = "https://v3.football.api-sports.io/";

            return new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri(baseUrl + query),
                Headers = {
                    {"x-rapidapi-host","v3.football.api-sports.io" },
                    {"x-rapidapi-key", key}
                }
            };
        }
    }
}
