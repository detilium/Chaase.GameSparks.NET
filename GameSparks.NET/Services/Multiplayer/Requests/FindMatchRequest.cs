using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class FindMatchRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".FindMatchRequest"; } }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("matchGroup")]
        public string MatchGroup { get; set; }
        [JsonProperty("matchShortCode")]
        public string MatchShortCode { get; set; }
        [JsonProperty("skill")]
        public int Skill { get; set; }

        /// <summary>
        /// Initialize a new FindMatchRequest
        /// </summary>
        /// <param name="action"></param>
        /// <param name="matchGroup"></param>
        /// <param name="matchShortCode"></param>
        /// <param name="skill"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public FindMatchRequest(string action, string matchGroup, string matchShortCode, int skill, string playerId, string requestId = "")
        {
            Action = action;
            MatchGroup = matchGroup;
            MatchShortCode = matchShortCode;
            Skill = skill;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty FindMatchRequest
        /// </summary>
        public FindMatchRequest() { }
    }
}
