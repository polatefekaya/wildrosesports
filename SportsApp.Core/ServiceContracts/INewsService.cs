using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts {
    public interface INewsService {
        Task<News?> GetNewsInTopHeadlines(string country, string category, string language, string searchFor);
        Task<News?> GetNewsInEverything(string searchFor, string language);
    }
}
