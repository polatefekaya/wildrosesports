using System;
using System.Collections.Generic;

namespace SportsApp.Core.HelperContracts {
    public interface INewsServiceHelper {
        Task<T?> HttpGetRequest<T>(string uri);
    }
}
