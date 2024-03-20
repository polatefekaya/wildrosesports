using System.ComponentModel.DataAnnotations;
namespace SportsApp.Core.Domain.Entities.Player {
    public class LeagueEntity {
        [Key]
        public string? Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [MaxLength(60)]
        public string? Country { get; set; }

        [MaxLength(15)]
        public string? Season { get; set; }

        [Url]
        [MaxLength(100)]
        public string? LogoUrl { get; set; }

        [Url]
        [MaxLength (100)]
        public string? FlagUrl { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
