using SportsApp.Core.DTO.Player.Card;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra.Player {
    public class CardEntityService : ICardEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        public CardEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IEntityService entityService) { 
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
        }

        public CardResponse? Add(CardAddRequest? request) {
            //Handling Exceptions
            _exception.IntExceptions<CardAddRequest>(ref request);

            CardEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            _db.Cards.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }

        public CardAddRequest? CreateAddRequest(ref Players.Cards model) {
            return new CardAddRequest {
                Yellow = model.yellow,
                YellowRed = model.yellowred,
                Red = model.red
            };
        }
    }
}
