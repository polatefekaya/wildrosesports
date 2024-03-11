using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class DribbleRepository : IDribbleRepository {
        public Task<DribbleEntity> Add(DribbleEntity entity) {
            throw new NotImplementedException();
        }
    }
}
