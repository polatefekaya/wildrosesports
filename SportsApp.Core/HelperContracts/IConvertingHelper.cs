using System;
using System.Collections.Generic;

namespace SportsApp.Core.HelperContracts {
    public interface IConvertingHelper {
        Task<T?> ConvertResponseMessageToJson<T>(HttpResponseMessage response);
    }
}
