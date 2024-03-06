using SportsApp.Core.DTO.Player.Goal;
using System;
using System.Collections.Generic;

namespace SportsApp.Core.ServiceContracts.Infra.Player {
    public interface IGoalEntityService {
        GoalResponse? Add(GoalAddRequest? request);
        GoalAddRequest? CreateAddRequest(ref Players.Goals model);
    }
}
