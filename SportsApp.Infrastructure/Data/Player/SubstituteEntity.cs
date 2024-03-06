namespace SportsApp.Infrastructure.Data.Player {
    public class SubstituteEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? In { get; set; }

        public int? Out { get; set; }

        public int? Bench { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
