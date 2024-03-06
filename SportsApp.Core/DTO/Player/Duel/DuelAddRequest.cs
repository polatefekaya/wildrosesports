using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Duel {
    public class DuelAddRequest {
        [Range(0, 9999)]
        public int? Total { get; set; }
        [Range(0, 9999)]
        public int? Won { get; set; }

        [Range(0, 100, MaximumIsExclusive = false)]
        public int? SuccessRate { get; set; }

        public DuelEntity ToEntity() {
            return new DuelEntity {
                Total = this.Total,
                Won = this.Won,
                SuccessRate = this.SuccessRate
            };
        }
    }
}
