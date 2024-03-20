using System.ComponentModel.DataAnnotations;
namespace SportsApp.Core.Domain.Entities.Player {
    public class ShotEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? On { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
