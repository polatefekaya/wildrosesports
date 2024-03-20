using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    //instead of Addrequest, we will use entities
    public interface IPlayerRepository {
        Task<PlayerEntity> Add(PlayerEntity entity);
    }
}
