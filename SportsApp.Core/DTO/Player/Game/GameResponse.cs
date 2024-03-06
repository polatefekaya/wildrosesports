using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Game {
    public class GameResponse {
        public Guid? Id { get; set; }

        public int? Appearences { get; set; }

        public int? Lineups { get; set; }

        public int? Minutes { get; set; }

        public int? Number { get; set; }

        [MaxLength(30)]
        public string? Position { get; set; }

        [MaxLength(12)]
        public string? Rating { get; set; }
        public bool? Captain { get; set; }
    }

    public static class GameEntityExtensions {
        public static GameResponse ToResponse (this GameEntity game) {
            return new GameResponse {
                Id = game.Id,
                Appearences = game.Appearences,
                Lineups = game.Lineups,
                Minutes = game.Minutes,
                Number = game.Number,
                Position = game.Position,
                Rating = game.Rating,
                Captain = game.Captain,
            };
        }
    }
}
