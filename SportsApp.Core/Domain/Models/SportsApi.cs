using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Entities {
    public class SportsApi {
        public class Players {
            public string? Id { get; set; }
            public string? TeamId { get; set; }
            public string? LeagueId { get; set; }
            public string? Search { get; set; }
            public string? Season { get; set; }
        }
    }
}
