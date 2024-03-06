using SportsApp.Core.DTO.Player.Game;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IGameEntityService {
        GameResponse? Add(GameAddRequest? request);
        GameAddRequest? CreateAddRequest(ref Players.Games model);
    }
}
