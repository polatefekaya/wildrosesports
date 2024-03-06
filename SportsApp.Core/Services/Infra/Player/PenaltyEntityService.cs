using SportsApp.Core.DTO.Player.League;
using SportsApp.Core.DTO.Player.Penalty;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class PenaltyEntityService : IPenaltyEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public PenaltyEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public PenaltyResponse? Add(PenaltyAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<PenaltyAddRequest>(ref request);

            PenaltyEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Penalties.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public PenaltyAddRequest? CreateAddRequest(ref Players.Penalty model) {
            return new PenaltyAddRequest {
                Committed = model.commited,
                Missed = model.missed,
                Saved = model.saved,
                Won = model.won,
                Scored = model.scored
            };
        }
    }
}
