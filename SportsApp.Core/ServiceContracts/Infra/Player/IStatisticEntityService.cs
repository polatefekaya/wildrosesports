using SportsApp.Core.DTO.Player.Statistic;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player
{
    public interface IStatisticEntityService
    {
        StatisticResponse Add(StatisticAddRequest? request);
        StatisticResponse[] Add(StatisticAddRequest?[] requests);

        StatisticAddRequest? CreateAddRequest(ref Players? model, int page = -1);
        StatisticAddRequest?[] CreateAddRequests(ref Players? model);
    }
}
