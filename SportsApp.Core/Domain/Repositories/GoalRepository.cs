using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.Repositories {
    public class GoalRepository : IGoalRepository {
        public Task<GoalEntity> Add(GoalEntity entity) {
            throw new NotImplementedException();
        }
    }
}
