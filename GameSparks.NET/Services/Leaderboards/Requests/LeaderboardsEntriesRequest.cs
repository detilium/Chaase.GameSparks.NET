using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Requests
{
    public class LeaderboardsEntriesRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ""; } }
        [JsonProperty("challenges")]
        public List<string> Challenges { get; set; }
        [JsonProperty("inverseSocial")]
        public bool InverseSocial { get; set; }
        [JsonProperty("leaderboards")]
        public List<string> Leaderboards { get; set; }
        [JsonProperty("player")]
        public string Player { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("social")]
        public bool Social { get; set; }
        [JsonProperty("teamTypes")]
        public List<string> TeamTypes { get; set; }

        /// <summary>
        /// Initialize a new LeaderboardsEntriesRequest
        /// </summary>
        /// <param name="challenges"></param>
        /// <param name="inverseSocial"></param>
        /// <param name="leaderboards"></param>
        /// <param name="player"></param>
        /// <param name="playerId"></param>
        /// <param name="social"></param>
        /// <param name="teamTypes"></param>
        /// <param name="requestId"></param>
        public LeaderboardsEntriesRequest(List<string> challenges, bool inverseSocial, List<string> leaderboards, string player, string playerId, bool social, List<string> teamTypes, string requestId = "")
        {
            Challenges = challenges;
            InverseSocial = inverseSocial;
            Leaderboards = leaderboards;
            Player = player;
            PlayerId = playerId;
            Social = social;
            TeamTypes = teamTypes;
            RequestId = requestId;
        }
    }
}
