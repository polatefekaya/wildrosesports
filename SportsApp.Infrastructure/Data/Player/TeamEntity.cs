namespace SportsApp.Infrastructure.Data.Player {
    public class TeamEntity {
        [Key]
        public string? Id { get; set; }

        [MaxLength(60)]
        public string? Name { get; set; }

        [Url]
        [MaxLength(100)]
        public string? LogoUrl { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
