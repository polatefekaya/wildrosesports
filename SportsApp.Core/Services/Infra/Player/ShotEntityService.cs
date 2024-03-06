using SportsApp.Core.DTO.Player.League;
using SportsApp.Core.DTO.Player.Shot;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class ShotEntityService : IShotEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public ShotEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public ShotResponse? Add(ShotAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<ShotAddRequest>(ref request);

            ShotEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Shots.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public ShotAddRequest? CreateAddRequest(ref Players.Shots model) {
            return new ShotAddRequest {
                On = model.on,
                Total = model.total
            };
        }
    }
}
