using GameSparks.NET.Authentication.Entitites;
using GameSparks.NET.Authentication.Infrastructure;
using GameSparks.NET.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Services
{
    public class GameSparksConnectService
    {
        #region Synchronous
        public List<GameSparksRepository> ListBitbucketRepositories()
        {
            return JsonConvert.DeserializeObject<List<GameSparksRepository>>(Requestor.GetString(Urls.BitBucketListRepos).ResponseJson);
        }
        #endregion

        #region Asynchronous

        #endregion
    }
}
