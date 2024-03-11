using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class PlayerRepository : IPlayerRepository {
        public Task<PlayerEntity> Add(PlayerEntity entity) {
            throw new NotImplementedException();
        }
    }
}
