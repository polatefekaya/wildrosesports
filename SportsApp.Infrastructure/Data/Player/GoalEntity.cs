namespace SportsApp.Infrastructure.Data.Player {
    public class GoalEntity {
        [Key]
        public Guid Id { get; set; }

        public int? Total { get; set; }

        public int? Conceded { get; set; }

        public int? Assists { get; set; }

        public int? Saves { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
