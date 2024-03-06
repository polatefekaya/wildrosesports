using SportsApp.Core.DTO.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player
{
    public interface IPlayerEntityService
    {
        PlayerResponse Add(PlayerAddRequest? request);
        PlayerResponse? GetPlayerById(string? playerId);
        PlayerAddRequest? CreateAddRequest(ref Players.Player model);
    }
}
