using System;
using System.Collections.Generic;

namespace SportsApp.Core.HelperContracts {
    public interface IOpenAIServiceHelper {
        Task<T?> CompletionsHttpPostRequest<T>(string uri);
    }
}
