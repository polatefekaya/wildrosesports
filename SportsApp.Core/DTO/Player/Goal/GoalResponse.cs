using SportsApp.Core.DTO.Player.Pass;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Goal {
    public class GoalResponse {
        public Guid Id { get; set; }

        [Range(0, 9999)]
        public int? Total { get; set; }

        [Range(0, 9999)]
        public int? Conceded { get; set; }

        [Range(0, 9999)]
        public int? Assists { get; set; }

        [Range(0, 9999)]
        public int? Saves { get; set; }
    }

    public static class GoalEntityExtensions {
        public static GoalResponse ToResponse(this GoalEntity goal) {
            return new GoalResponse {
                Id = goal.Id,
                Total = goal.Total,
                Conceded = goal.Conceded,
                Assists = goal.Assists,
                Saves = goal.Saves
            };
        }
    }
}
