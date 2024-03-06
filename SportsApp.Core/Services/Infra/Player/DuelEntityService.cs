using SportsApp.Core.DTO.Player.Duel;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class DuelEntityService : IDuelEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public DuelEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public DuelResponse? Add(DuelAddRequest? request) {
            _exception.IntExceptions<DuelAddRequest>(ref request);

            DuelEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Duels.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public DuelAddRequest? CreateAddRequest(ref Players.Duels model) {
            return new DuelAddRequest {
                SuccessRate = CalculateSuccessRate(model.total, model.won),
                Won = model.won,
                Total = model.total
            };
        }

        private int? CalculateSuccessRate(int? total, int? won) {
            return ((won/total)*100);
        }

    }
    
}
