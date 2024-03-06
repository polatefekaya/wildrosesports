using SportsApp.Core.DTO.Player.Dribble;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class DribbleEntityService : IDribbleEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public DribbleEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public DribbleResponse? Add(DribbleAddRequest? request) {
            _exception.IntExceptions<DribbleAddRequest>(ref request);

            DribbleEntity entity = request.ToEntity();

            _entities.AddEssentials(ref entity);

            _db.Dribbles.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public DribbleAddRequest? CreateAddRequest(ref Players.Dribbles model) {
            return new DribbleAddRequest {
                Success = model.success,
                Attempts = model.attempts,
                Past = model.past
            };
        }
    }
}
