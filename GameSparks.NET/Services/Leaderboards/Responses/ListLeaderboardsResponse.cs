using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Responses
{
    public class ListLeaderboardsResponse : GameSparksBaseResponse
    {
        [JsonProperty("leaderboards")]
        public List<GameSparksLeaderboardData> Leaderboards { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
    }
}
