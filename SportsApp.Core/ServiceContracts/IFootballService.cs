using SportsApp.Core.Domain.Entities;

namespace SportsApp.Core.ServiceContracts {
    public interface IFootballService {
        Task<TeamStandings?> GetStandings(string leagueId, string season);
        Task<Players?> GetPlayersByTeam(string id, string season);
        Task<Players?> GetPlayer(string id, string season);
        Task<Players?> GetTopScorers(string playerId, string season); //TODO: Refactor object types 
        Task<Players?> GetTrophies(string playerId, string season); //TODO: Refactor object types
        Task<Players?> GetTransfers(string playerId, string season); //TODO: Refactor object types
    }
}