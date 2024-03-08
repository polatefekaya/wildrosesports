using SportsApp.Core.HelperContracts.Infra;
using SportsApp.Core.Services.Infra;
using SportsApp.Infrastructure.Data.Player;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.Helpers.Infra {
    public class PlayerDbServiceHelper : IPlayerDbServiceHelper {

        private Dictionary<Type, Action<Players?, int>> _typeMethods = new Dictionary<Type, Action<Players?, int>>();

        public PlayerDbServiceHelper() {
            InitializeTypeMethods();
        }

        private void InitializeTypeMethods() {
            _typeMethods.Add(typeof(TeamEntity), new Action<Players?, int>(AddTeam));
        }

        private void AddTeam(Players? model, int statisticPage) {
            throw new NotImplementedException();
        }

        public void Add<T>(ref Players? player, int statisticPage) where T : class {
            if (!_typeMethods.ContainsKey(typeof(T))) {
                throw new ArgumentException($"There is no initialized type like provided one ({nameof(T)}) in {nameof(PlayerDbServiceHelper)}.{nameof(_typeMethods)}, please initialize it with it's method");
            }

            _typeMethods[typeof(T)].Invoke(player, statisticPage);
        }
    }
}
