using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class FoulRepository : IFoulRepository {
        public Task<FoulEntity> Add(FoulEntity entity) {
            throw new NotImplementedException();
        }
    }
}
