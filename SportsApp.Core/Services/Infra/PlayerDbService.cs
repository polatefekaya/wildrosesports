using SportsApp.Core.HelperContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace SportsApp.Core.Services.Infra
{
    public class PlayerDbService : IPlayerDbService
    {
        //Fetch Data from api
        //get the model
        //make the db calls

        private readonly IFootballService _footballService;

        private readonly IStatisticEntityService _statistic;
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

        private readonly IPlayerDbServiceHelper _playerDbHelper;

        private Dictionary<Type, Action<Players?, int>> _typeMethods = new Dictionary<Type, Action<Players?, int>>();
        public PlayerDbService(IFootballService footballService, IPlayerDbServiceHelper dbServiceHelper, IStatisticEntityService statistic, IDribbleEntityService dribble, ICardEntityService card, IDuelEntityService duel, IFoulEntityService foul, IPlayerEntityService player, IGoalEntityService goal, IGameEntityService game, IEntityService entityService, ILeagueEntityService league, IPassEntityService pass, IPenaltyEntityService penalty, IShotEntityService shot, ISubstituteEntityService substitute, ITackleEntityService tackle, ITeamEntityService team)
        {
            _footballService = footballService;
            _statistic = statistic;
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

            _playerDbHelper = dbServiceHelper;

            InitializeTypeMethods();
        }

        private void InitializeTypeMethods() {
            _typeMethods.Add(typeof(TeamEntity), new Action<Players?, int>(AddTeam));
        }

        public async Task<Players?> FetchPlayer(string id, string season)
        {
            Players? model = await _footballService.GetPlayer(id, season);
            AddAllEntites(ref model);

            return model;
        }

        private void AddAllEntites(ref Players? model)
        {
            //AddPlayer(ref playersModel);
            AddStatistics(ref model);
            _playerDbHelper.Add<TeamEntity>(ref model, 0);
            //Add<Players.Player>(ref model, 1);
        }

        public void AddPlayer(ref Players? model) {
            Players.Player entity = model.response[0].player;
            _player.Add(_player.CreateAddRequest(ref entity));
        }

        Dictionary<Type, Type> serviceTypes = new Dictionary<Type, Type>() {
            {typeof(Players.League), typeof(ILeagueEntityService) },
            {typeof(Players.Player), typeof(IPlayerEntityService) },

        };

        public void AddLeague(ref Players? model, int statisticPage) {
            Players.League? entity = model?.response?[0].statistics?[statisticPage].league;

            try {
                _league.Add(_league.CreateAddRequest(ref entity));

            } catch (Exception ex){
                Debug.WriteLine(ex.Message);
            }

        }

        public void AddTeam(Players? model, int statisticPage) {
            Players.Team? entity = model?.response?[0].statistics?[statisticPage].team;

            try {
                _team.Add(_team.CreateAddRequest(ref entity));

            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void AddStatistics(ref Players? model)
        {
            //Statistic[] entities = model.response[0].statistics;
            _statistic.Add(_statistic.CreateAddRequests(ref model));
        }

        public void Add<T>(ref Players? player, int statisticPage) where T : class {
            if (!_typeMethods.ContainsKey(typeof(T))) {
                throw new ArgumentException($"There is no initialized type like this in {nameof(PlayerDbService)}.{nameof(_typeMethods)}, please initialize it with it's method");
            }

            _typeMethods[typeof(T)].Invoke(player, statisticPage);
        }
    }
}
