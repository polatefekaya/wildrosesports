using SportsApp.Core.DTO.Player.League;
using SportsApp.Core.DTO.Player.Pass;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class PassEntityService : IPassEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public PassEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public PassResponse? Add(PassAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<PassAddRequest>(ref request);

            PassEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Passes.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public PassAddRequest? CreateAddRequest(ref Players.Passes model) {
            return new PassAddRequest {
                Accuracy = model.accuracy,
                Key = model.key,
                Total = model.total
            };
        }
    }
}
