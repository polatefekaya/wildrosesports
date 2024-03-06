using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra {
    public interface IEntityService {
        public void AddEssentials<TEntity>(ref TEntity entity);
    }
}
