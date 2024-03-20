using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Card {
    public class CardAddRequest {

        [Range(0, 9999)]
        public int? Yellow { get; set; }
        [Range(0, 9999)]
        public int? YellowRed { get; set; }
        [Range(0, 9999)]
        public int? Red { get; set; }

        public CardEntity ToEntity() {
            return new CardEntity { 
                Yellow = this.Yellow,
                YellowRed = this.YellowRed,
                Red = this.Red
            };
        }
    }
}
