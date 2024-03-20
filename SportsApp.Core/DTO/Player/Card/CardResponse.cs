using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Card {
    public class CardResponse {

        public Guid? Id { get; set; }
        public int? Yellow { get; set; }
        public int? YellowRed { get; set; }
        public int? Red { get; set; }
    }

    public static class CardEntityExtensions {
        public static CardResponse ToResponse(this CardEntity card) {
            return new CardResponse {
                Id = card.Id,
                Yellow = card.Yellow,
                YellowRed = card.YellowRed,
                Red = card.Red,
            };
        }
    }
}
