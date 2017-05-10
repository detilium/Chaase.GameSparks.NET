using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Responses
{
    public class GameSparksLeaderboardDataResponse : GameSparksBaseResponse
    {
        [JsonProperty("challengeInstanceId")]
        public string ChallengeInstanceId { get; set; }
        [JsonProperty("data")]
        public List<GameSparksLeaderboardUserData> Data { get; set; }
        [JsonProperty("first")]
        public List<GameSparksLeaderboardUserData> First { get; set; }
        [JsonProperty("last")]
        public List<GameSparksLeaderboardUserData> Last { get; set; }
        [JsonProperty("leaderboardShortCode")]
        public string LeaderboardShortCode { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
        [JsonProperty("social")]
        public bool Social { get; set; }
    }
}
