﻿using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Domain.RepositoryContracts {
    public interface IDuelRepository {
        Task<DuelEntity> Add(DuelEntity entity);
    }
}
