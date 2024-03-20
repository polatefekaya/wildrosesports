using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SportsApp.Core.DTO.Player
{
    public class PlayerAddRequest
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

        public DateTime? BirthDate { get; set; }

        [MaxLength(25)]
        public string? BirthPlace { get; set; }

        [MaxLength(25)]
        public string? BirthCountry { get; set; }

        public PlayerEntity ToEntity(){
            return new PlayerEntity()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Age = this.Age,
                Nationality = this.Nationality,
                Height = this.Height,
                Weight = this.Weight,
                Injured = this.Injured,
                PhotoUrl = this.PhotoUrl,
                BirthDate = this.BirthDate,
                BirthPlace = this.BirthPlace,
                BirthCountry = this.BirthCountry
            };
        }
    }
}
