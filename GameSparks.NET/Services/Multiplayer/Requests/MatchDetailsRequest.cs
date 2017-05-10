using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class MatchDetailsRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".MatchDetailsRequest"; } }
        [JsonProperty("matchId")]
        public string MatchId { get; set; }
        [JsonProperty("realtimeEnabled")]
        public bool RealtimeEnabled { get; set; }

        /// <summary>
        /// Initialize a new MatchDetailsRequest
        /// </summary>
        /// <param name="matchId"></param>
        /// <param name="realtimeEnabled"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public MatchDetailsRequest(string matchId, bool realtimeEnabled, string playerId, string requestId = "")
        {
            MatchId = matchId;
            RealtimeEnabled = realtimeEnabled;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty MatchDetailsRequest
        /// </summary>
        public MatchDetailsRequest() { }
    }
}
