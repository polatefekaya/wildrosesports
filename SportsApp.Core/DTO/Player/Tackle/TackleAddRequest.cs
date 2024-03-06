using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Tackle {
    public class TackleAddRequest {
        [Range(0, 9999)]
        public int? Total { get; set; }
        [Range(0, 9999)]
        public int? Blocks { get; set; }
        [Range(0, 9999)]
        public int? Interceptions { get; set; }

        public TackleEntity ToEntity() {
            return new TackleEntity {
                Total = this.Total,
                Blocks = this.Blocks,
                Interceptions = this.Interceptions
            };
        }
    }
}
