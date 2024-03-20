using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SportsApp.Core.Domain.Entities.Player;

namespace SportsApp.Core.DTO.Player
{
    public class PlayerResponse
    {
        [MaxLength(10)]
        public string? Id { get; set; }

        [MaxLength(25)]
        public string? FirstName { get; set; }

        [MaxLength(25)]
        public string? LastName { get; set; }

        [Range(1, 150)]
        public int? Age { get; set; }

        [MaxLength(25)]
        public string? Nationality { get; set; }

        [MaxLength(15)]
        public string? Height { get; set; }

        [MaxLength(15)]
        public string? Weight { get; set; }

        public bool? Injured { get; set; }

        [Url]
        [MaxLength(100)]
        public string? PhotoUrl { get; set; }

        public DateTime? BirtDate { get; set; }

        [MaxLength(25)]
        public string? BirthPlace { get; set; }

        [MaxLength(25)]
        public string? BirthCountry { get; set; }
    }

    public static class PlayerEntityExtensions
    {
        public static PlayerResponse ToResponse(this PlayerEntity player)
        {
            return new PlayerResponse { 
                Id = player.Id,
                FirstName = player.FirstName,
                LastName = player.LastName,
                Age = player.Age,
                Nationality = player.Nationality,
                Height = player.Height,
                Weight = player.Weight,
                Injured = player.Injured,
                PhotoUrl = player.PhotoUrl,
                BirtDate = player.BirthDate,
                BirthPlace = player.BirthPlace,
                BirthCountry = player.BirthCountry
            };
        }
    }
}
