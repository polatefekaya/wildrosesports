using SportsApp.Core.DTO.Player.Dribble;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IDribbleEntityService {
        DribbleResponse? Add(DribbleAddRequest? request);
        DribbleAddRequest? CreateAddRequest(ref Players.Dribbles model);
    }
}
