using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.DTO.Player.Statistic {
    public class StatisticAddRequest {

        public string? PlayerId { get; set; }

        public PlayerEntity? Player { get; set; }

        public string? TeamId { get; set; }

        public TeamEntity? Team { get; set; }

        public string? LeagueId { get; set; }

        public LeagueEntity? League { get; set; }

        public GameEntity? Game { get; set; }

        public GoalEntity? Goal { get; set; }

        public SubstituteEntity? Substitute { get; set; }

        public ShotEntity? Shot { get; set; }

        public PassEntity? Pass { get; set; }

        public TackleEntity? Tackle { get; set; }

        public DuelEntity? Duel { get; set; }

        public DribbleEntity? Dribble { get; set; }

        public FoulEntity? Foul { get; set; }
 
        public CardEntity? Card { get; set; }

        public PenaltyEntity? Penalty { get; set; }


        public StatisticEntity ToEntity() {
            return new StatisticEntity {
                PlayerId = this.PlayerId,
                Player = this.Player,
                TeamId = this.TeamId,
                Team = this.Team,
                LeagueId = this.LeagueId,
                League = this.League,
                GameId = this.Game?.Id,
                Game = this.Game,
                SubstitueId = this.Substitute?.Id,
                Substitute = this.Substitute,
                ShotId = this.Shot?.Id,
                Shot = this.Shot,
                PassId = this.Pass?.Id,
                Pass = this.Pass,
                TackleId = this.Tackle?.Id,
                Tackle = this.Tackle,
                DuelId = this.Duel?.Id,
                Duel = this.Duel,
                DribbleId = this.Dribble?.Id,
                Dribble = this.Dribble,
                FoulId = this.Foul?.Id,
                Foul = this.Foul,
                CardId = this.Card?.Id,
                Card = this.Card,
                PenaltyId = this.Penalty?.Id,
                Penalty = this.Penalty,
                GoalId = this.Goal?.Id,
                Goal = this.Goal,
            };
        }
    }
}
