﻿using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    public interface IStatisticRepository {
        Task<StatisticEntity> Add(StatisticEntity entity);
    }
}
