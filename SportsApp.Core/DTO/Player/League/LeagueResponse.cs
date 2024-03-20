using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.League {
    public class LeagueResponse {
        public string? Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [MaxLength(60)]
        public string? Country { get; set; }

        [MaxLength(15)]
        public string? Season { get; set; }

        [Url]
        [MaxLength(100)]
        public string? LogoUrl { get; set; }

        [Url]
        [MaxLength(100)]
        public string? FlagUrl { get; set; }
    }

    public static class LeagueEntityExtensions {
        public static LeagueResponse ToResponse (this LeagueEntity league) {
            return new LeagueResponse {
                Id = league.Id,
                Name = league.Name,
                Country = league.Country,
                Season = league.Season,
                LogoUrl = league.LogoUrl,
                FlagUrl = league.FlagUrl
            };
        }
    }
}
