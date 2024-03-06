using Azure.Core;
using Microsoft.IdentityModel.Tokens;
using SportsApp.Core.DTO.Player.League;
using SportsApp.Core.DTO.Player.Statistic;
using SportsApp.Core.DTO.Player.Tackle;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using static SportsApp.Core.Domain.Entities.Players;

namespace SportsApp.Core.Services.Infra.Player
{
    public class StatisticEntityService : IStatisticEntityService {
        private readonly PlayerDbContext _db;
        private readonly IEntityExceptionService _exception;
        private readonly IEntityService _entities;

        private readonly ILeagueEntityService _league;
        private readonly IPlayerEntityService _player;
        private readonly ICardEntityService _card;
        private readonly IDribbleEntityService _dribble;
        private readonly IDuelEntityService _duel;
        private readonly IFoulEntityService _foul;
        private readonly IGameEntityService _game;
        private readonly IGoalEntityService _goal;
        private readonly IPassEntityService _pass;
        private readonly IPenaltyEntityService _penalty;
        private readonly IShotEntityService _shot;
        private readonly ISubstituteEntityService _substitute;
        private readonly ITackleEntityService _tackle;
        private readonly ITeamEntityService _team;

        public StatisticEntityService(PlayerDbContext playerDbContext, IEntityExceptionService entityExceptionService, IDribbleEntityService dribble, ICardEntityService card, IDuelEntityService duel, IFoulEntityService foul, IPlayerEntityService player, IGoalEntityService goal, IGameEntityService game, IEntityService entityService, ILeagueEntityService league, IPassEntityService pass, IPenaltyEntityService penalty, IShotEntityService shot, ISubstituteEntityService substitute, ITackleEntityService tackle, ITeamEntityService team) {
            _db = playerDbContext;
            _exception = entityExceptionService;
            _entities = entityService;
            _league = league;
            _pass = pass;
            _penalty = penalty;
            _shot = shot;
            _substitute = substitute;
            _tackle = tackle;
            _team = team;
            _game = game;
            _goal = goal;
            _player = player;
            _foul = foul;
            _duel = duel;
            _card = card;
            _dribble = dribble;
        }

        public StatisticResponse?[] Add(StatisticAddRequest?[] requests) {
            StatisticResponse?[] statisticResponses = new StatisticResponse?[requests.Length];

            //TODO: Tries to add team, league and player in each iteration. It should be once

            for (int i = 0; i < requests.Length; i++) {
                _exception.IntExceptions<StatisticAddRequest>(ref requests[i]);

                StatisticEntity entity = requests[i].ToEntity();
                _entities.AddEssentials(ref entity);

                bool isIdsNull = (entity.TeamId == null || entity.LeagueId == null || entity.PlayerId == null);
                if (isIdsNull) {
                    statisticResponses[i] = entity.ToResponse();
                    continue;
                }

                _db.Statistics.Add(entity);
                _db.SaveChanges();

                statisticResponses[i] = entity.ToResponse();
            }

            return statisticResponses;
        }

        public StatisticResponse? Add(StatisticAddRequest? request){
            //Handling Exceptions
            _exception.IntExceptions<StatisticAddRequest>(ref request);

            StatisticEntity entity = request.ToEntity();
            _entities.AddEssentials(ref entity);

            bool isIdsNull = (entity.TeamId == null || entity.LeagueId == null || entity.PlayerId == null);
            if (isIdsNull) {
                return null;
            }

            _db.Statistics.Add(entity);
            _db.SaveChanges();

            return entity.ToResponse();
        }


        public StatisticAddRequest? CreateAddRequest(ref Players? model, int page = 0) {
            Players.Statistic? entity = model?.response?[0].statistics?[page];
            Players.Player? player = model?.response?[0].player;

            return InitializeStatisticRequest(ref entity, ref player);
        }

        public StatisticAddRequest?[] CreateAddRequests(ref Players? model) {
            StatisticAddRequest?[] requests = new StatisticAddRequest?[model.response[0].statistics.Length];
            Players.Player? player = model.response[0].player;

            for (int i = 0; i < model?.response[0]?.statistics?.Length; i++) {
                Players.Statistic? statistic = model?.response[0].statistics?[i];
                requests[i] = InitializeStatisticRequest(ref statistic, ref player, i == 0);
            }

            return requests;
        }

        private StatisticAddRequest? InitializeStatisticRequest(ref Players.Statistic? entity, ref Players.Player? player, bool firstTime = true) {
            StatisticAddRequest request = new StatisticAddRequest {
                Game = InitGame(ref entity),
                Card = InitCard(ref entity),
                Dribble = InitDribble(ref entity),
                Duel = InitDuel(ref entity),
                Foul = InitFoul(ref entity),
                Goal = InitGoal(ref entity),
                Pass = InitPass(ref entity),
                Penalty = InitPenalty(ref entity),
                Shot = InitShot(ref entity),
                Substitute = InitSubstitute(ref entity),
                Tackle = InitTackle(ref entity),
                Player = InitPlayer(ref player),
                Team = InitTeam(ref entity),
                League = InitLeague(ref entity)
        };

            request.PlayerId = player?.id.ToString();

            if (String.IsNullOrWhiteSpace(entity?.league?.id.ToString())) { 
                request.LeagueId = null;
            } else {
                request.LeagueId = entity?.league?.id.ToString(); }

            if(String.IsNullOrWhiteSpace(entity?.team?.id.ToString())) { 
                request.TeamId = null;
            } else {
                request.TeamId = entity?.team?.id.ToString(); }

            /*
            if (firstTime) {
                request.Player = InitPlayer(ref player);
                request.Team = InitTeam(ref entity);
                request.League = InitLeague(ref entity);
            }
            */

            return request;
        }

        private LeagueEntity? InitLeague(ref Players.Statistic? model) {
            if (model == null) return null;

            Players.League? entity = model?.league;
            if (entity == null) return null;

            LeagueEntity? obj = _league.CreateAddRequest(ref entity)?.ToEntity();

            if (_db.Leagues.Count(temp => String.Equals(temp.Id, obj.Id)) > 0) {
                return null;
            }

            _entities.AddEssentials(ref obj);

            return obj;
        }
        private LeagueEntity? InitLeagueBase(ref Statistic? model) {
            if (model == null) return null;

            LeagueEntity entity = new LeagueEntity { Id = model.league.id.ToString() };
            _entities.AddEssentials(ref entity);

            return entity;
        }

        private PlayerEntity? InitPlayer(ref Players.Player? model) {
            if (model == null) return null;

            PlayerEntity? obj = _player.CreateAddRequest(ref model)?.ToEntity();

            if(_db.Players.Count(temp => String.Equals(temp.Id, obj.Id)) > 0) {
                return null;
            }

            _entities.AddEssentials(ref obj);

            return obj;
        }

        private PlayerEntity? InitPlayerBase(ref Players.Player? model) {
            if (model == null) return null;

            PlayerEntity entity = new PlayerEntity { Id = model.id.ToString() };
            _entities.AddEssentials(ref entity);

            return entity;
        }

        private TeamEntity? InitTeam(ref Players.Statistic? model) {
            if (model == null) return null;

            Players.Team? entity = model?.team;
            if (entity == null) return null;

            TeamEntity? obj = _team.CreateAddRequest(ref entity)?.ToEntity();

            if (_db.Teams.Count(temp => String.Equals(temp.Id, obj.Id)) > 0) {
                return null;
            }

            _entities.AddEssentials(ref obj);

            return obj;
        }

        private TeamEntity? InitTeamBase(ref Statistic? model) {
            if (model == null) return null;

            TeamEntity entity = new TeamEntity { Id = model.team.id.ToString() };
            _entities.AddEssentials(ref entity);

            return entity;
        }

        private GameEntity? InitGame(ref Players.Statistic? model) {
            Players.Games? entity = model?.games;
            GameEntity? obj = _game.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private CardEntity? InitCard(ref Players.Statistic? model) {
            Players.Cards? entity = model?.cards;
            CardEntity? obj = _card.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private DribbleEntity? InitDribble(ref Players.Statistic? model) {
            Players.Dribbles? entity = model?.dribbles;
            DribbleEntity? obj = _dribble.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private DuelEntity? InitDuel(ref Players.Statistic? model) {
            Players.Duels? entity = model?.duels;
            DuelEntity? obj = _duel.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private FoulEntity? InitFoul(ref Players.Statistic? model) {
            Players.Fouls? entity = model?.fouls;
            FoulEntity? obj = _foul.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private GoalEntity? InitGoal(ref Players.Statistic? model) {
            Players.Goals? entity = model?.goals;
            GoalEntity? obj = _goal.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private PassEntity? InitPass(ref Players.Statistic? model) {
            Players.Passes? entity = model?.passes;
            PassEntity? obj = _pass.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private PenaltyEntity? InitPenalty(ref Players.Statistic? model) {
            Players.Penalty? entity = model?.penalty;
            PenaltyEntity? obj = _penalty.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private ShotEntity? InitShot(ref Players.Statistic? model) {
            Players.Shots? entity = model?.shots;
            ShotEntity? obj = _shot.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private SubstituteEntity? InitSubstitute(ref Players.Statistic? model) {
            Players.Substitutes? entity = model?.substitutes;
            SubstituteEntity? obj = _substitute.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

        private TackleEntity? InitTackle(ref Players.Statistic? model) {
            Players.Tackles? entity = model?.tackles;
            TackleEntity? obj = _tackle?.CreateAddRequest(ref entity)?.ToEntity();
            _entities.AddEssentials(ref obj);

            return obj;
        }

    }
}
