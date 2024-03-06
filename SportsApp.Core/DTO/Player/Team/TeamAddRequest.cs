using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Team
{
    public class TeamAddRequest{
        //Id is have to be given because we get this data from api
        public string? Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [Url]
        [MaxLength(100)]
        public string? LogoUrl { get; set; }

        public TeamEntity ToEntity() {
            return new TeamEntity {
                Id = Id,
                Name = this.Name,
                LogoUrl = this.LogoUrl
            };
        }
    }
}
