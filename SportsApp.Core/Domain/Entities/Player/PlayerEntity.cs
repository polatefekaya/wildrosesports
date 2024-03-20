using System.ComponentModel.DataAnnotations;
namespace SportsApp.Core.Domain.Entities.Player {
    public class PlayerEntity {
        [Key]
        public string? Id { get; set; }

        [MaxLength(25)]
        public string? FirstName { get; set; }

        [MaxLength(25)]
        public string? LastName { get; set;}

        [Range(1,150)]
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

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
