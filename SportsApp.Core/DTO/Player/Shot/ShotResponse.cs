using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Shot {
    public class ShotResponse {
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? On { get; set; }
    }

    public static class ShotEntityExtensions {
        public static ShotResponse ToResponse (this ShotEntity shot) {
            return new ShotResponse {
                Id = shot.Id,
                Total = shot.Total,
                On = shot.On
            };
        }
    }
}
