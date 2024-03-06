using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Dribble {
    public class DribbleResponse {
        public Guid? Id { get; set; }
        public int? Attempts { get; set; }
        public int? Success { get; set; }
        public int? Past { get; set; }
    }

    public static class DribbleEntityExtensions {
        public static DribbleResponse ToResponse(this DribbleEntity dribble) {
            return new DribbleResponse {
                Id = dribble.Id,
                Attempts = dribble.Attempts,
                Success = dribble.Success,
                Past = dribble.Past,
            };
        }
    }
}
