using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Penalty {
    public class PenaltyResponse {
        public Guid? Id { get; set; }

        public int? Won { get; set; }

        public int? Committed { get; set; }

        public int? Scored { get; set; }

        public int? Missed { get; set; }

        public int? Saved { get; set; }
    }

    public static class PenaltyEntityExtensions {
        public static PenaltyResponse ToResponse (this PenaltyEntity penalty) {
            return new PenaltyResponse {
                Id = penalty.Id,
                Won = penalty.Won,
                Committed = penalty.Committed,
                Scored = penalty.Scored,
                Missed = penalty.Missed,
                Saved = penalty.Saved
            };
        }
    }
}
