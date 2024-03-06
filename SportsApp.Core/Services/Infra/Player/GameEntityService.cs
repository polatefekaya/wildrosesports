using SportsApp.Core.DTO.Player.Game;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class GameEntityService : IGameEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public GameEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public GameResponse? Add(GameAddRequest? request) {
            _exception.IntExceptions(ref request);
            _exception.StringExceptions(ref request);
            _exception.BoolExceptions(ref request);

            GameEntity entity = request.ToEntity();

            _entities.AddEssentials(ref entity);

            _db.Games.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public GameAddRequest? CreateAddRequest(ref Players.Games model) {
            return new GameAddRequest {
                Appearences = model.appearences,
                Captain = model.captain,
                Lineups = model.lineups,
                Minutes = model.minutes,
                Number = model.number,
                Position = model.position,
                Rating = model.rating
            };
        }
    }
}
