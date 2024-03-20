using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Substitute {
    public class SubstituteResponse {
        public Guid? Id { get; set; }

        public int? In { get; set; }

        public int? Out { get; set; }

        public int? Bench { get; set; }
    }

    public static class SubstituteEntityExtensions{
        public static SubstituteResponse ToResponse (this SubstituteEntity substitute) {
            return new SubstituteResponse {
                Id = substitute.Id,
                In = substitute.In,
                Out = substitute.Out,
                Bench = substitute.Bench
            };
        }
    }
}
