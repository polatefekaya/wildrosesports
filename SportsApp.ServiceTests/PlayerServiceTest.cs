using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SportsApp.Core.DTO.Player;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Core.Services.Infra;
using SportsApp.Core.Services.Infra.Player;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.ServiceTests
{
    public class PlayerServiceTest {
        private readonly IPlayerEntityService _playerService;

        public PlayerServiceTest() {
            _playerService = new PlayerEntityService(new PlayerDbContext(new DbContextOptionsBuilder<PlayerDbContext>(new DbContextOptions<PlayerDbContext>()).Options), new EntityExceptionService(), new EntityService());
        }

        //When PlayerAddRequest is null, it should throw ArgumentNull Exception
        [Fact]
        public void AddPlayer_NullPlayer() {
            //Arrange
            PlayerAddRequest? request = null;

            //Assert
            Assert.Throws<ArgumentNullException>(() => {
                //Act
                _playerService.Add(request);
            });
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
            PlayerAddRequest? request1 = new PlayerAddRequest() {
                Id = "1"
            };
            PlayerAddRequest? request2 = new PlayerAddRequest() {
                Id = "1"
            };

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
            PlayerAddRequest? request = new PlayerAddRequest() {
                Id = "1",
                FirstName = "Poyraz",
                LastName = "Kaya"
            };

            //Act
            PlayerResponse response = _playerService.Add(request);

            //Assert
            Assert.True(response.Id != String.Empty || response.Id is not null);
        }
    }
}
