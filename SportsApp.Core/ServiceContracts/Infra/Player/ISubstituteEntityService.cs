using SportsApp.Core.DTO.Player.Substitute;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface ISubstituteEntityService {
        SubstituteResponse Add(SubstituteAddRequest? request);
        SubstituteAddRequest? CreateAddRequest(ref Players.Substitutes model);
    }
}
