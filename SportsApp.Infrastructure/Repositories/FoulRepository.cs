using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class FoulRepository : IFoulRepository {
        public Task<FoulEntity> Add(FoulEntity entity) {
            throw new NotImplementedException();
        }
    }
}
