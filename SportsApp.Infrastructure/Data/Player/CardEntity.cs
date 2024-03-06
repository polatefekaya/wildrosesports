namespace SportsApp.Infrastructure.Data.Player {
    public class CardEntity {
        [Key]
        public Guid? Id { get; set; }

        public int? Yellow { get; set; }

        public int? YellowRed { get; set; }

        public int? Red { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
