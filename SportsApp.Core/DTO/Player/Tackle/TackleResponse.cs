using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Tackle {
    public class TackleResponse {
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Blocks { get; set; }

        public int? Interceptions { get; set; }
    }

    public static class TackleEntityExtensions {
        public static TackleResponse ToResponse (this TackleEntity tackle) {
            return new TackleResponse {
                Id = tackle.Id,
                Total = tackle.Total,
                Blocks = tackle.Blocks,
                Interceptions = tackle.Interceptions
            };
        }
    }
}
