using SportsApp.Core.DTO.Player.League;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface ILeagueEntityService {
        LeagueResponse Add(LeagueAddRequest? request);
        LeagueAddRequest? CreateAddRequest(ref Players.League model);
    }
}
