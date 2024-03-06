using SportsApp.Core.DTO.Player.Statistic;
using SportsApp.Core.DTO.Player.Tackle;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class TackleEntityService : ITackleEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public TackleEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public TackleResponse Add(TackleAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<TackleAddRequest>(ref request);

            TackleEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Tackles.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public TackleAddRequest? CreateAddRequest(ref Players.Tackles model) {
            return new TackleAddRequest {
                Total = model.total,
                Blocks = model.blocks,
                Interceptions = model.interceptions
            };
        }
    }
}
