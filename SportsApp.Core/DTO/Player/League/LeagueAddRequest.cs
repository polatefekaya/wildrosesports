using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.League
    {
    public class LeagueAddRequest {
        //Id is have to be given because we get this data from api
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

        public LeagueEntity ToEntity() {
            return new LeagueEntity {
                Id = this.Id,
                Name = this.Name,
                Country = this.Country,
                Season = this.Season,
                LogoUrl = this.LogoUrl,
                FlagUrl = this.FlagUrl
            };
        }
    }
}
