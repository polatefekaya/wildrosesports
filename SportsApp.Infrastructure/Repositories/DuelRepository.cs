using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class DuelRepository : IDuelRepository {
        public Task<DuelEntity> Add(DuelEntity entity) {
            throw new NotImplementedException();
        }
    }
}
