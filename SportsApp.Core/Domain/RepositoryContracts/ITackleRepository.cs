using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    public interface ITackleRepository {
        Task<TackleEntity> Add(TackleEntity entity);
    }
}
