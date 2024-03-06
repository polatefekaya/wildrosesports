using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services {
    public class NewsService : INewsService {
        private readonly INewsServiceHelper _helper;

        private readonly string _baseUrl = "https://newsapi.org/v2/";
        public NewsService(INewsServiceHelper newsServiceHelper) { 
            _helper = newsServiceHelper;
        }

        public async Task<News?> GetNewsInEverything(string searchFor, string language) {
            string uri = $"{_baseUrl}everything?q={searchFor}&language={language}";
            string uriNew = $"{_baseUrl}everything?q={searchFor}";
            return await _helper.HttpGetRequest<News?>(uri);
        }

        public async Task<News?> GetNewsInTopHeadlines(string country, string category, string language, string searchFor) {
            string uri = $"{_baseUrl}top-headlines?country={country}&category={category}&q={searchFor}";
            return await _helper.HttpGetRequest<News?>(uri);
        }
    }
}
