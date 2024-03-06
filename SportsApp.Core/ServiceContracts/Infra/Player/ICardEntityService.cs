using SportsApp.Core.DTO.Player.Card;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface ICardEntityService {
        CardResponse? Add(CardAddRequest? request);
        CardAddRequest? CreateAddRequest(ref Players.Cards model);
    }
}
