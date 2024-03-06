using SportsApp.Core.DTO.Player;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SportsApp.Core.Services.Infra.Player
{
    public class PlayerEntityService : IPlayerEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public PlayerEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public PlayerResponse Add(PlayerAddRequest? request){

            _exception.IntExceptions(ref request);
            _exception.BoolExceptions(ref request);
            _exception.StringExceptions(ref request);

            //Validation: Id can't be duplicate
            if (_db.Players
                .Count(temp => string.Equals(temp.Id, request.Id)) > 0)
            {
                throw new ArgumentException("Given Id already exists");
                //return new PlayerResponse();
            }

            PlayerEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Players.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public PlayerResponse? GetPlayerById(string? playerId)
        {
            if (playerId is null)
            {
                return null;
            }

            PlayerEntity? player = _db.Players
                .FirstOrDefault(temp => string.Equals(temp.Id, playerId));

            if (player is null)
            {
                return null;
            }

            return player.ToResponse();
        }

        public PlayerAddRequest? CreateAddRequest(ref Players.Player model) {
            return new PlayerAddRequest {
                Id = model.id.ToString(),
                FirstName = model.firstname,
                LastName = model.lastname,
                Age = model.age,
                Height = model.height,
                Weight = model.weight,
                Injured = model.injured,
                Nationality = model.nationality,
                PhotoUrl = model.photo,
                BirthDate = Convert.ToDateTime(model.birth.date),
                BirthCountry = model.birth.country,
                BirthPlace = model.birth.place
            };
        }
    }
}
