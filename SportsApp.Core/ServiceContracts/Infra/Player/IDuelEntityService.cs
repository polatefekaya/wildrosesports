using SportsApp.Core.DTO.Player.Duel;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IDuelEntityService {
        DuelResponse? Add(DuelAddRequest? request);
        DuelAddRequest? CreateAddRequest(ref Players.Duels model);
    }
}
