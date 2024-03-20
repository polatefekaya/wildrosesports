using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class PenaltyRepository : IPenaltyRepository {
        public Task<PenaltyEntity> Add(PenaltyEntity entity) {
            throw new NotImplementedException();
        }
    }
}
