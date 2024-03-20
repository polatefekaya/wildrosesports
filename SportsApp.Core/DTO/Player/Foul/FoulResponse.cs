using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Foul {
    public class FoulResponse {
        public Guid? Id { get; set; }
        public int? Drawn { get; set; }
        public int? Committed { get; set; }
    }

    public static class FoulEntityExtensions {
        public static FoulResponse ToResponse (this FoulEntity foul) {
            return new FoulResponse {
                Id = foul.Id,
                Drawn = foul.Drawn,
                Committed = foul.Committed
            };
        }
    }
}
