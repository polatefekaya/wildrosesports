using SportsApp.Core.DTO.Player.Foul;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IFoulEntityService {
        FoulResponse? Add(FoulAddRequest? request);
        FoulAddRequest? CreateAddRequest(ref Players.Fouls model);
    }
}
