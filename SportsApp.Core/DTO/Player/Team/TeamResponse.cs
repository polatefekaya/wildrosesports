using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Team {
    public class TeamResponse {
        public string? Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [Url]
        [MaxLength(100)]
        public string? LogoUrl { get; set; }
    }

    public static class TeamEntityExtensions{
        public static TeamResponse ToResponse (this TeamEntity team) {
            return new TeamResponse {
                Id = team.Id,
                Name = team.Name,
                LogoUrl = team.LogoUrl
            };
        }
    }
}
