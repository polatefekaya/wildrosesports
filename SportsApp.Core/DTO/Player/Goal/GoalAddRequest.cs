using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Goal {
    public class GoalAddRequest {

        [Range(0,9999)]
        public int? Total { get; set; }

        [Range(0, 9999)]
        public int? Conceded { get; set; }

        [Range(0, 9999)]
        public int? Assists { get; set; }

        [Range(0, 9999)]
        public int? Saves { get; set; }

        public GoalEntity ToEntity() {
            return new GoalEntity {
                Total = this.Total,
                Conceded = this.Conceded,
                Assists = this.Assists,
                Saves = this.Saves
            };
        }
    }
}
