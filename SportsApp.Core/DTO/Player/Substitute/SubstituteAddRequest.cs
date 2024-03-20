using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Substitute {
    public class SubstituteAddRequest {
        [Range(0, 9999)]
        public int? In { get; set; }
        [Range(0, 9999)]
        public int? Out { get; set; }
        [Range(0, 9999)]
        public int? Bench { get; set; }

        public SubstituteEntity ToEntity() {
            return new SubstituteEntity { 
                In = this.In,
                Out = this.Out,
                Bench = this.Bench
            };
        }
    }
}
