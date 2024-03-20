namespace SportsApp.Core.Domain.Entities {
    public class TeamStandings {
        public ParametersData? Parameters { get; set; }
        public object[]? Errors { get; set; }

        public ResponseData[]? Response { get; set; }

        public class ResponseData {
            public LeagueData? League { get; set; }
        }

        public class ParametersData {
            public string? League { get; set; }
            public string? Season { get; set; }
        }

        public class LeagueData {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Country { get; set; }
            public string? Logo { get; set; }
            public string? Flag { get; set; }
            public int Season { get; set; }
            public StandingData[][]? Standings { get; set; }
        }
        public class StandingData {
            public int Rank { get; set; }
            public TeamData? Team { get; set; }
            public int Points { get; set; }
            public int GoalsDiff { get; set; }
            public string? Group { get; set; }
            public string? Form { get; set; }
            public string? Status { get; set; }
            public string? Despriction { get; set; }
            public Match? All { get; set; }
            public Match? Home { get; set; }
            public Match? Away { get; set; }
            public string? Update { get; set; }

            public class TeamData {
                public int Id { get; set; }
                public string? Name { get; set; }
                public string? Logo { get; set; }
            }

            public class Match {
                public int Played { get; set; }
                public int Win { get; set; }
                public int Draw { get; set; }
                public int Lose { get; set; }
                public GoalsData? Goals { get; set; }
            }

            public class GoalsData {
                public int For { get; set; }
                public int Against { get; set; }
            }
        }
    }
}
