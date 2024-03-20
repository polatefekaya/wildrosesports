using Microsoft.EntityFrameworkCore;
using SportsApp.Core.DTO.Player.Card;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Core.Services.Infra;
using SportsApp.Core.Services.Infra.Player;
using SportsApp.Infrastructure.DbContext;
using System;
using System.Collections.Generic;

namespace SportsApp.ServiceTests
{
    public class CardEntityServiceTest {
        private readonly ICardEntityService _cardEntityService;
        public CardEntityServiceTest() {
            _cardEntityService = new CardEntityService(new PlayerDbContext(new DbContextOptionsBuilder<PlayerDbContext>().Options), new EntityExceptionService(), new EntityService());
        }

        [Fact]
        public void AddCard_NullYellowRed () {
            CardAddRequest request = new CardAddRequest {
                YellowRed = null
            };

            Assert.Throws<ArgumentException>(() => {
                _cardEntityService.Add(request);
            });
        }

        [Fact]
        public void AddCard_BelowZeroYellowRed() {
            CardAddRequest request = new CardAddRequest {
                YellowRed = -2
            };

            Assert.Throws<ArgumentException>(() => {
                _cardEntityService.Add(request);
            });
        }

        [Fact]
        public void AddCard_NullYellow() {
            CardAddRequest request = new CardAddRequest {
                Yellow = null
            };

            Assert.Throws<ArgumentException>(() => {
                _cardEntityService.Add(request);
            });
        }
    }
}
