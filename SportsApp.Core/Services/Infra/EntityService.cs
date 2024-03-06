using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;

namespace SportsApp.Core.Services.Infra {
    public class EntityService : IEntityService {

        public void AddEssentials<TEntity>(ref TEntity entity) {
            bool isGuid = entity?.GetType()?.GetProperty("Id")?.GetType() == typeof(Guid?);
            if(isGuid) {
                entity?.GetType().GetProperty("Id")?.SetValue(entity, Guid.NewGuid());
            }
            entity.GetType().GetProperty("CreatedAt")?.SetValue(entity, DateTime.UtcNow);
            entity.GetType().GetProperty("UpdatedAt")?.SetValue(entity, DateTime.UtcNow);
        }
    }
}
