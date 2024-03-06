using SportsApp.Core.DTO.Player.Penalty;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IPenaltyEntityService {
        PenaltyResponse? Add (PenaltyAddRequest? request);
        PenaltyAddRequest? CreateAddRequest(ref Players.Penalty model);
    }
}
