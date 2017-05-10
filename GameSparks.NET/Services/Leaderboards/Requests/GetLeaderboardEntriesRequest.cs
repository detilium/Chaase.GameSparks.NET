using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Requests
{
    public class GetLeaderboardEntriesRequest : GameSparksBaseLeaderboardsRequest
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
        [JsonProperty("social")]
        public bool Social { get; set; }
        [JsonProperty("teamTypes")]
        public List<string> TeamTypes { get; set; }

        /// <summary>
        /// Initialize a new GetLeaderboardEntriesRequest
        /// </summary>
        /// <param name="challenges"></param>
        /// <param name="inverseSocial"></param>
        /// <param name="leaderboards"></param>
        /// <param name="player"></param>
        /// <param name="social"></param>
        /// <param name="teamTypes"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetLeaderboardEntriesRequest(List<string> challenges, bool inverseSocial, List<string> leaderboards, string player, bool social, List<string> teamTypes, string playerId, string requestId = "")
        {
            Challenges = challenges;
            InverseSocial = inverseSocial;
            Leaderboards = leaderboards;
            Player = player;
            Social = social;
            TeamTypes = teamTypes;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
