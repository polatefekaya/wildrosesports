using SportsApp.Core.DTO.Player.Shot;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IShotEntityService {
        ShotResponse? Add(ShotAddRequest? request);
        ShotAddRequest? CreateAddRequest(ref Players.Shots model);
    }
}
