using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SportsApp.Core.DTO.Player;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Core.Services.Infra;
using SportsApp.Core.Services.Infra.Player;
using SportsApp.Core.Domain.Entities.Player;
using System;
using System.Collections.Generic;
using Moq;
using EntityFrameworkCoreMock;
using AutoFixture;
using FluentAssertions;
using SportsApp.Infrastructure.DbContext;

namespace SportsApp.ServiceTests
{
    public class PlayerServiceTest {
        private readonly IPlayerEntityService _playerService;
        private readonly IFixture _fixture;

        public PlayerServiceTest() {
            _fixture = new Fixture();


            var playersInitialData = new List<PlayerEntity>() { };

            var dbContextMock = new DbContextMock<PlayerDbContext>(
                new DbContextOptionsBuilder<PlayerDbContext>().Options
                );
            var entityExMock = new Mock<EntityExceptionService>();
            var entityServiceMock = new Mock<EntityService>();

            var dbContext = dbContextMock.Object;
            var entityEx = entityExMock.Object;
            var entityService = entityServiceMock.Object;

            dbContextMock.CreateDbSetMock(temp => temp.Players, playersInitialData);
            

            _playerService = new PlayerEntityService(dbContext, entityEx, entityService);
        }

        //When PlayerAddRequest is null, it should throw ArgumentNull Exception
        [Fact]
        public void AddPlayer_NullPlayer() {
            //Arrange
            PlayerAddRequest? request = null;

            Action action = () => {
                _playerService.Add(request);
            };

            action.Should().Throw<ArgumentNullException>();
            //Assert
            /*
            Assert.Throws<ArgumentNullException>(() => {
                //Act
                _playerService.Add(request);
            });
            */
        }

        //When the PlayerName is null, it should throw ArgumentException
        [Fact]
        public void AddPlayer_NullId() {
            //Arrange
            PlayerAddRequest? request = new PlayerAddRequest() {
                Id = null
            };

            //Assert
            Assert.Throws<ArgumentException>(() => {
                //Act
                _playerService.Add(request);
            });
        }

        [Fact]
        public void AddPlayer_NullFirstName() {
            //Arrange
            PlayerAddRequest? request = new PlayerAddRequest() {
                FirstName = null
            };

            //Assert
            Assert.Throws<ArgumentException>(() => {
                //Act
                _playerService.Add(request);
            });
        }

        [Fact]
        public void AddPlayer_NullLastName() {
            //Arrange
            PlayerAddRequest? request = new PlayerAddRequest() {
                LastName = null
            };

            //Assert
            Assert.Throws<ArgumentException>(() => {
                //Act
                _playerService.Add(request);
            });
        }

        //When the PlayerId is duplicate, it should throw ArgumentException
        [Fact]
        public void AddPlayer_DuplicateId() {
            //Arrange
            PlayerAddRequest? request1 = _fixture.Build<PlayerAddRequest>()
                .With(temp => temp.Id, "1")
                .Create();
            PlayerAddRequest? request2 = _fixture.Build<PlayerAddRequest>()
                .With(temp => temp.Id, "1")
                .Create();

            //Assert
            Assert.Throws<ArgumentException>(() => {
                //Act
                _playerService.Add(request1);
                _playerService.Add(request2);
            });
        }

        //When you supply proper PlayerId, it should insert (add) the player to the database
        [Fact]
        public void AddPlayer_ProperPlayerDetails() {
            //Arrange
            //TODO: Normalde Idyi biz guid ile generate edeceğiz ama serverdan çektiğimiz bilgilerde id zaten geliyor
            PlayerAddRequest? request = _fixture.Create<PlayerAddRequest>();

            //Act
            PlayerResponse response = _playerService.Add(request);

            //Assert
            Assert.True(response.Id != String.Empty || response.Id is not null);
        }
    }
}
