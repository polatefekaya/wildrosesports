using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Foul {
    public class FoulAddRequest {
        [Range(0, 9999)]
        public int? Drawn { get; set; }
        [Range(0, 9999)]
        public int? Committed { get; set; }

        public FoulEntity ToEntity() {
            return new FoulEntity() {
                Drawn = this.Drawn,
                Committed = this.Committed,
            };
        }

        public class Add {

        }
    }
}
