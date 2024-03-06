using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsApp.Core.DTO.Player.Statistic {
    public class StatisticResponse {

        public Guid? Id { get; set; }

        public string? PlayerId { get; set; }
        public  PlayerEntity? Player { get; set; }

        public string? TeamId { get; set; }
        public  TeamEntity? Team { get; set; }

        public string? LeagueId { get; set; }
        public LeagueEntity? League { get; set; }

        public Guid? GameId { get; set; }
        public GameEntity? Game { get; set; }

        public Guid? SubstitueId { get; set; }
        public SubstituteEntity? Substitute { get; set; }

        public Guid? ShotId { get; set; }
        public ShotEntity? Shot { get; set; }

        public Guid? PassId { get; set; }
        public PassEntity? Pass { get; set; }

        public Guid? TackleId { get; set; }
        public TackleEntity? Tackle { get; set; }

        public Guid? DuelId { get; set; }
        public DuelEntity? Duel { get; set; }

        public Guid? DribbleId { get; set; }
        public DribbleEntity? Dribble { get; set; }

        public Guid? FoulId { get; set; }
        public FoulEntity? Foul { get; set; }

        public Guid? CardId { get; set; }
        public CardEntity? Card { get; set; }

        public Guid? PenaltyId { get; set; }
        public PenaltyEntity? Penalty { get; set; }

        public Guid? GoalId { get; set; }
        public GoalEntity? Goal { get; set; }

    }

    public static class StatictisExtensions {
        public static StatisticResponse ToResponse(this StatisticEntity statistic) {
            return new StatisticResponse {
                Id = statistic.Id,
                PlayerId = statistic.PlayerId,
                Player = statistic.Player,
                TeamId = statistic.TeamId,
                Team = statistic.Team,
                LeagueId = statistic.LeagueId,
                League = statistic.League,
                GameId = statistic.GameId,
                Game = statistic.Game,
                SubstitueId = statistic.SubstitueId,
                Substitute = statistic.Substitute,
                ShotId = statistic.ShotId,
                Shot = statistic.Shot,
                PassId = statistic.PassId,
                Pass = statistic.Pass,
                TackleId = statistic.TackleId,
                Tackle = statistic.Tackle,
                DuelId = statistic.DuelId,
                Duel = statistic.Duel,
                DribbleId = statistic.DribbleId,
                Dribble = statistic.Dribble,
                FoulId = statistic.FoulId,
                Foul = statistic.Foul,
                CardId = statistic.CardId,
                Card = statistic.Card,
                PenaltyId = statistic.PenaltyId,
                Penalty = statistic.Penalty,
                GoalId = statistic.GoalId,
                Goal = statistic.Goal
            };
        }
    }
}
