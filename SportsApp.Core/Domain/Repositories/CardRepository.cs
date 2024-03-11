using SportsApp.Core.Domain.RepositoryContracts;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Doamain.Repositories {
    public class CardRepository : ICardRepository {
        public Task<CardEntity> Add(CardEntity entity) {
            throw new NotImplementedException();
        }
    }
}
