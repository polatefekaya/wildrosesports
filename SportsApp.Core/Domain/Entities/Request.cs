using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Entities {
    public class Request {
        public required string BaseUrl { get; set; }
        public required string FinalUrl { get; set; }
        public required HttpMethod Method { get; set; }
        public Dictionary<string, string>? Headers { get; set; }
    }
}
