using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Penalty {
    public class PenaltyAddRequest {
        [Range(0, 9999)]
        public int? Won { get; set; }
        [Range(0, 9999)]
        public int? Committed { get; set; }
        [Range(0, 9999)]
        public int? Scored { get; set; }
        [Range(0, 9999)]
        public int? Missed { get; set; }
        [Range(0, 9999)]
        public int? Saved { get; set; }

        public PenaltyEntity ToEntity() {
            return new PenaltyEntity {
                Won = this.Won,
                Committed = this.Committed,
                Scored = this.Scored,
                Missed = this.Missed,
                Saved = this.Saved
            };
        }
    }
}
