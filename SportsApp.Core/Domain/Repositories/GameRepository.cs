using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class GameRepository : IGameRepository {
        public Task<GameEntity> Add(GameEntity entity) {
            throw new NotImplementedException();
        }
    }
}
