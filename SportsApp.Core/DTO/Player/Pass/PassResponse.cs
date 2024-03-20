using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.DTO.Player.Pass {
    public class PassResponse {
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Key { get; set; }

        [Range(0, 100)]
        public int? Accuracy { get; set; }

    }

    public static class PassEntityExtensions {
        public static PassResponse ToResponse (this PassEntity pass) {
            return new PassResponse {
                Id = pass.Id,
                Total = pass.Total,
                Key = pass.Key,
                Accuracy = pass.Accuracy
            };
        }
    }
}
