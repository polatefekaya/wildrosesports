using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    public interface ISubstituteRepository {
        Task<SubstituteEntity> Add(SubstituteEntity entity);
    }
}
