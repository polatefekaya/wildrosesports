using SportsApp.Core.DTO.Player.Tackle;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface ITackleEntityService {
        TackleResponse Add(TackleAddRequest? request);
        TackleAddRequest? CreateAddRequest(ref Players.Tackles model);
    }
}
