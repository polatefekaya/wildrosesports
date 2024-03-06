namespace SportsApp.Infrastructure.Data.Player {
    public class DribbleEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Attempts { get; set; }

        public int? Success { get; set; }

        public int? Past { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
