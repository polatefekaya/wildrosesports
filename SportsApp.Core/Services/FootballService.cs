namespace SportsApp.Core.Services {
    public class FootballService : IFootballService {

        private readonly IFootballServiceHelper _footballServiceHelper;

        private readonly string _baseUrl = "https://v3.football.api-sports.io/";
        private readonly string _mode = "standings";

        public FootballService(IFootballServiceHelper footballServiceHelper) {
            _footballServiceHelper = footballServiceHelper;
        }
        public async Task<TeamStandings?> GetStandings(string leagueId, string season) {

            return await _footballServiceHelper.HttpGetRequest<TeamStandings?>($"{_baseUrl}standings?league={leagueId}&season={season}");
        }

        public async Task<Players?> GetPlayersByTeam(string? id, string season) {
            if (id is null) id = "0";
            if (season is null) season = "2023";
            return await _footballServiceHelper.HttpGetRequest<Players?>($"{_baseUrl}players?team={id}&season={season}");
        }

        public async Task<Players?> GetPlayer(string? id, string season) {
            if (id is null) id = "0";
            if (season is null) season = "2023";
            return await _footballServiceHelper.HttpGetRequest<Players?>($"{_baseUrl}players?id={id}&season={season}");
        }

        public Task<Players?> GetTopScorers(string playerId, string season) {
            throw new NotImplementedException();
        }

        public Task<Players?> GetTrophies(string playerId, string season) {
            throw new NotImplementedException();
        }

        public Task<Players?> GetTransfers(string playerId, string season) {
            throw new NotImplementedException();
        }
    }
}
