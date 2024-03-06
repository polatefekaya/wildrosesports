using SportsApp.Core.DTO.Player.Foul;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class FoulEntityService : IFoulEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public FoulEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public FoulResponse? Add(FoulAddRequest? request) {
            _exception.IntExceptions<FoulAddRequest>(ref request);

            FoulEntity entity = request.ToEntity();

            _entities.AddEssentials(ref entity);

            _db.Fouls.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public FoulAddRequest? CreateAddRequest(ref Players.Fouls model) {
            return new FoulAddRequest {
                Committed = model.committed,
                Drawn = model.drawn
            };
        }
    }
}
