using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsApp.Core.Domain.Entities.Player {
    public class StatisticEntity {
        [Key]
        public Guid? Id { get; set; }

        public string? PlayerId { get; set; }

        [ForeignKey("PlayerId")]
        public virtual PlayerEntity? Player { get; set; }

        public string? TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual TeamEntity? Team { get; set; }

        public string? LeagueId { get; set; }

        [ForeignKey("LeagueId")]
        public virtual LeagueEntity? League { get; set; }

        public Guid? GameId { get; set; }

        [ForeignKey("GameId")]
        public virtual GameEntity? Game { get; set; }

        public Guid? GoalId { get; set; }

        [ForeignKey("GoalId")]
        public virtual GoalEntity? Goal { get; set; }

        public Guid? SubstitueId { get; set; }

        [ForeignKey("SubstitueId")]
        public virtual SubstituteEntity? Substitute { get; set; }

        public Guid? ShotId { get; set; }

        [ForeignKey("ShotId")]
        public virtual ShotEntity? Shot { get; set; }

        public Guid? PassId { get; set; }

        [ForeignKey("PassId")]
        public virtual PassEntity? Pass { get; set; }

        public Guid? TackleId { get; set; }

        [ForeignKey("TackleId")]
        public virtual TackleEntity? Tackle { get; set; }

        public Guid? DuelId { get; set; }

        [ForeignKey("DuelId")]
        public virtual DuelEntity? Duel { get; set; }

        public Guid? DribbleId { get; set; }

        [ForeignKey("DribbleId")]
        public virtual DribbleEntity? Dribble { get; set; }

        public Guid? FoulId { get; set; }

        [ForeignKey("FoulId")]
        public virtual FoulEntity? Foul { get; set; }

        public Guid? CardId { get; set; }

        [ForeignKey("CardId")]
        public virtual CardEntity? Card { get; set; }

        public Guid? PenaltyId { get; set; }

        [ForeignKey("PenaltyId")]
        public virtual PenaltyEntity? Penalty { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
    }
}
