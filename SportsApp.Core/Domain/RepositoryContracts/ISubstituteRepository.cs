using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    public interface ISubstituteRepository {
        Task<SubstituteEntity> Add(SubstituteEntity entity);
    }
}
