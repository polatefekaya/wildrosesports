using SportsApp.Core.DTO.Player.Statistic;
using SportsApp.Core.DTO.Player.Substitute;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class SubstituteEntityService : ISubstituteEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public SubstituteEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public SubstituteResponse Add(SubstituteAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<SubstituteAddRequest>(ref request);

            SubstituteEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Substitutes.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public SubstituteAddRequest? CreateAddRequest(ref Players.Substitutes model) {
            return new SubstituteAddRequest {
                Bench = model.bench,
                In = model._in,
                Out = model._out
            };
        }
    }
}
