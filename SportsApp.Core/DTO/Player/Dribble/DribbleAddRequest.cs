using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Dribble {
    public class DribbleAddRequest {
        [Range(0, 9999)]
        public int? Attempts { get; set; }
        [Range(0, 9999)]
        public int? Success { get; set; }
        [Range(0, 9999)]
        public int? Past { get; set; }

        public DribbleEntity ToEntity() {
            return new DribbleEntity {
                Attempts = this.Attempts,
                Success = this.Success,
                Past = this.Past
            };
        } 
    }
}
