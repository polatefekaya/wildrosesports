namespace SportsApp.Infrastructure.Data.Player {
    public class PenaltyEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Won { get; set; }

        public int? Committed { get; set; }

        public int? Scored { get; set; }

        public int? Missed { get; set; }

        public int? Saved { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
