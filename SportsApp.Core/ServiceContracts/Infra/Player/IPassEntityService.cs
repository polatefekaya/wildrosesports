using SportsApp.Core.DTO.Player.Pass;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IPassEntityService {
        PassResponse? Add(PassAddRequest? request);
        PassAddRequest? CreateAddRequest(ref Players.Passes model);
    }
}
