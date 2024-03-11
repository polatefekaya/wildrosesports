using SportsApp.Core.Services.Factories;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Factories {
    public interface IRequestMessageFactory {
        public RequestMessageFactory Create();
        public HttpRequestMessage SportsApi(string? key, string query);
    }
}
