using SportsApp.Core.DTO.Player.Goal;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class GoalEntityService : IGoalEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public GoalEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public GoalResponse? Add(GoalAddRequest? request) {
            _exception.IntExceptions(ref request);

            GoalEntity entity = request.ToEntity();

            _entities.AddEssentials(ref entity);

            _db.Goals.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public GoalAddRequest? CreateAddRequest(ref Players.Goals model) {
            return new GoalAddRequest {
                Total = model.total,
                Conceded = model.conceded,
                Assists = model.assists,
                Saves = model.saves
            };
        }
    }
}
