using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Pass {
    public class PassAddRequest {
        [Range(0, 9999)]
        public int? Total { get; set; }
        [Range(0, 9999)]
        public int? Key { get; set; }

        [Range(0, 100, MaximumIsExclusive = false)]
        public int? Accuracy { get; set; }

        public PassEntity ToEntity() {
            return new PassEntity {
                Total = this.Total,
                Key = this.Key,
                Accuracy = this.Accuracy
            };
        }
    }
}
