using SportsApp.Core.DTO.Player.Team;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface ITeamEntityService {
        TeamResponse Add(TeamAddRequest? request);
        TeamAddRequest? CreateAddRequest(ref Players.Team model);
    }
}
