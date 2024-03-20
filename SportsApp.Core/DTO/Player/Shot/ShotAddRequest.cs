using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Shot {
    public class ShotAddRequest {
        [Range(0, 9999)]
        public int? Total { get; set; }
        [Range(0, 9999)]
        public int? On { get; set; }

        public ShotEntity ToEntity() {
            return new ShotEntity {
                Total = this.Total,
                On = this.On
            };
        }
    }
}
