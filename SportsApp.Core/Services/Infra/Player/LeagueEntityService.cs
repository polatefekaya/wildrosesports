using SportsApp.Core.DTO.Player.Card;
using SportsApp.Core.DTO.Player.League;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class LeagueEntityService : ILeagueEntityService {

        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public LeagueEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public LeagueResponse Add(LeagueAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<LeagueAddRequest>(ref request);

            if (_db.Leagues
                .Count(temp => string.Equals(temp.Id, request.Id)) > 0) {
                //return new LeagueResponse();
                throw new ArgumentException("Given Id already exists");
            }

            LeagueEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Leagues.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public LeagueAddRequest? CreateAddRequest(ref Players.League model) {
            return new LeagueAddRequest {
                Country = model.country,
                FlagUrl = model.flag,
                Id = model.id.ToString(),
                LogoUrl = model.logo,
                Name = model.name,
                Season = model.season
            };
        }
    }
}
