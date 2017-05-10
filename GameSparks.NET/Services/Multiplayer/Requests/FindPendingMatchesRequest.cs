using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class FindPendingMatchesRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".FindPendingMatchesRequest"; } }
        [JsonProperty("matchGroup")]
        public string MatchGroup { get; set; }
        [JsonProperty("matchShortCode")]
        public string MatchShortCode { get; set; }
        [JsonProperty("maxMatchesToFind")]
        public int MaxMatchesToFind { get; set; }

        /// <summary>
        /// Intialize a new FindPendingMatchesRequest
        /// </summary>
        /// <param name="matchGroup"></param>
        /// <param name="matchShortCode"></param>
        /// <param name="maxMatchesToFind"></param>
        public FindPendingMatchesRequest(string matchGroup, string matchShortCode, string maxMatchesToFind, string playerId, string requestId = "")
        {
            MatchGroup = matchGroup;
            MatchShortCode = matchShortCode;
            MaxMatchesToFind = MaxMatchesToFind;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty FindPendingMatchesRequest
        /// </summary>
        public FindPendingMatchesRequest() { }
    }
}
