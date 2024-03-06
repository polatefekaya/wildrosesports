namespace SportsApp.Infrastructure.Data.Player {
    public class GameEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Appearences { get; set; }

        public int? Lineups { get; set; }

        public int? Minutes { get; set; }

        public int? Number { get; set; }

        [MaxLength(30)]
        public string? Position { get; set; }

        [MaxLength(12)]
        public string? Rating { get; set; }

        public bool? Captain { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
