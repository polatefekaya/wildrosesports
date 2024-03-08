using System;
using System.Collections.Generic;

namespace SportsApp.Core.HelperContracts.Infra {
    public interface IPlayerDbServiceHelper {
        public void Add<T>(ref Players? model, int statisticPage) where T : class;
    }
}
