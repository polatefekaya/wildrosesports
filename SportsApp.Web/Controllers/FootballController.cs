using Microsoft.AspNetCore.Mvc;
using SportsApp.Core.ServiceContracts;
using SportsApp.Core.Domain.Entities;
using SportsApp.Core.ServiceContracts.Infra;

namespace Controllers {
    [Route("~/football")]
    public class FootballController : Controller {
        
        private readonly IFootballService _footballService;
        private readonly INewsService _newsService;
        private readonly IPlayerDbService _playerDbService;

        public FootballController(IFootballService footballService, INewsService newsService, IPlayerDbService playerDbService) {
            _footballService = footballService;
            _newsService = newsService;
            _playerDbService = playerDbService;
        }

        [Route("/")]
        public async Task<IActionResult> Index(string leagueId = "203", string season = "2023") {
            TeamStandings? standingsModel = await _footballService.GetStandings(leagueId: leagueId, season: season);
            return View(standingsModel);
        }

        [Route("/players/{id}")]
        public async Task<IActionResult> Team(string id = "0") {
            
            Players? playersModel = await _footballService.GetPlayersByTeam(id: id, season: "2023");
            string teamName = playersModel.response[0].statistics[0].team.name;
            News? newsModel = await _newsService.GetNewsInEverything(searchFor: teamName, language: "tr");

            ViewBag.News = newsModel;
            ViewBag.Players = playersModel;

            return View();
        }

        [Route("/player/{id}")]
        public async Task<IActionResult> Player(string id = "0", bool topNews = false) {
            Players? playerModel = await _playerDbService.FetchPlayer(id, "2023");
            //Players? playerModel = await _footballService.GetPlayer(id: id, season: "2023");
            string playerName = playerModel.response[0].player.firstname + " " + playerModel.response[0].player.lastname;

            News? newsModel = topNews ? 
                await _newsService.GetNewsInTopHeadlines(searchFor: playerName, language: "tr", country: "tr", category: "football") :
                await _newsService.GetNewsInEverything(searchFor: playerName, language: "tr");

            ViewBag.PlayerNews = newsModel;
            ViewBag.Player = playerModel;

            return View();
        }
    }
}
