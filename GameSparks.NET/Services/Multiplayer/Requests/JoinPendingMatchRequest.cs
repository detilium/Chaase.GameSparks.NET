using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class JoinPendingMatchRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".JoinPendingMatchRequest"; } }
        [JsonProperty("matchGroup")]
        public string MatchGroup { get; set; }
        [JsonProperty("matchShortCode")]
        public string MatchShortCode { get; set; }
        [JsonProperty("pendingMatchId")]
        public string PendingMatchId { get; set; }

        /// <summary>
        /// Initialize a new JoinPendingMatchRequest
        /// </summary>
        /// <param name="matchGroup"></param>
        /// <param name="machShortCode"></param>
        /// <param name="pendingMatchId"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public JoinPendingMatchRequest(string matchGroup, string matchShortCode, string pendingMatchId, string playerId, string requestId = "")
        {
            MatchGroup = matchGroup;
            MatchShortCode = matchShortCode;
            PendingMatchId = pendingMatchId;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty JoinPendingMatchRequest
        /// </summary>
        public JoinPendingMatchRequest() { }
    }
}
