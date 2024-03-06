namespace SportsApp.Infrastructure.Data.Player {
    public class PassEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Total { get; set; }

        public int? Key { get; set; }

        [Range(0,100)]
        public int? Accuracy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
