using System.ComponentModel.DataAnnotations;

namespace SportsApp.Core.Domain.Entities.Player {
    public class DuelEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Won { get; set; }

        [Range(0,100)]
        public int? SuccessRate { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}