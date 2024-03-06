using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Duel {
    public class DuelResponse {
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Won { get; set; }

        [Range(0, 100)]
        public int? SuccessRate { get; set; }
    }

    public static class DuelEntityExtensions {
        public static DuelResponse ToResponse(this DuelEntity duel) {
            return new DuelResponse {
                Id = duel.Id,
                Total = duel.Total,
                Won = duel.Won,
                SuccessRate = duel.SuccessRate
            };
        }
    }
}
