using SportsApp.Core.DTO.Player.Statistic;
using SportsApp.Core.DTO.Player.Team;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class TeamEntityService : ITeamEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public TeamEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public TeamResponse Add(TeamAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<TeamAddRequest>(ref request);
            
            if (_db.Teams
                .Count(temp => string.Equals(temp.Id, request.Id)) > 0) {
                throw new ArgumentException("Given Id already exists");
            }

            TeamEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Teams.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public TeamAddRequest? CreateAddRequest(ref Players.Team model) {
            return new TeamAddRequest {
                Id = model.id.ToString(),
                Name = model.name,
                LogoUrl = model.logo
            };
        }
    }
}
