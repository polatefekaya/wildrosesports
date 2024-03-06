using System;
using System.Collections.Generic;


namespace SportsApp.Core.ServiceContracts.Infra
{
    public interface IPlayerDbService
    {
        //public void AddAllEntites(ref Players model);
        //public void AddPlayer(ref Players model);
        public Task<Players?> FetchPlayer(string id, string season);
    }
}
