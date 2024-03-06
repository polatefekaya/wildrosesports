using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Game {
    public class GameAddRequest {
        [Range(0, 9999)]
        public int? Appearences { get; set; }
        [Range(0, 9999)]
        public int? Lineups { get; set; }
        [Range(0, 9999)]
        public int? Minutes { get; set; }
        [Range(0, 9999)]
        public int? Number { get; set; }

        [MaxLength(30)]
        public string? Position { get; set; }

        [MaxLength(12)]
        public string? Rating { get; set; }

        public bool? Captain { get; set; }

        public GameEntity ToEntity() {
            return new GameEntity {
                Appearences = this.Appearences,
                Lineups = this.Lineups,
                Minutes = this.Minutes,
                Number = this.Number,
                Position = this.Position,
                Rating = this.Rating,
                Captain = this.Captain
            };
        }
    }
}
