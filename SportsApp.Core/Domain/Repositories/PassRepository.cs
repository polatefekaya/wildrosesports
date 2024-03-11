using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class PassRepository : IPassRepository {
        public Task<PassEntity> Add(PassEntity entity) {
            throw new NotImplementedException();
        }
    }
}
