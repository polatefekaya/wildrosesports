using System.ComponentModel.DataAnnotations;
namespace SportsApp.Core.Domain.Entities.Player {
    public class FoulEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Drawn { get; set; }

        public int? Committed { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
