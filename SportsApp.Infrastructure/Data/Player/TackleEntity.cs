namespace SportsApp.Infrastructure.Data.Player {
    public class TackleEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Blocks { get; set; }

        public int? Interceptions { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
