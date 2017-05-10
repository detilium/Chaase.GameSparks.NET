using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class MatchmakingRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".MatchmakingRequest"; } }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("customQuery")]
        public dynamic CustomQuery { get; set; }
        [JsonProperty("matchData")]
        public dynamic MatchData { get; set; }
        [JsonProperty("matchGroup")]
        public string MatchGroup { get; set; }
        [JsonProperty("matchShortCode")]
        public string MatchShortCode { get; set; }
        [JsonProperty("participantData")]
        public dynamic ParticipantData { get; set; }
        [JsonProperty("skill")]
        public int Skill { get; set; }

        /// <summary>
        /// Initialize a new MatchmakingRequest
        /// </summary>
        /// <param name="action"></param>
        /// <param name="customQuery"></param>
        /// <param name="matchData"></param>
        /// <param name="matchGroup"></param>
        /// <param name="matchShortCode"></param>
        /// <param name="participantData"></param>
        /// <param name="skill"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public MatchmakingRequest(string action, dynamic customQuery, dynamic matchData, string matchGroup, string matchShortCode, dynamic participantData, int skill, string playerId, string requestId = "")
        {
            Action = action;
            CustomQuery = customQuery;
            MatchData = matchData;
            MatchShortCode = matchShortCode;
            ParticipantData = participantData;
            Skill = skill;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new ampty MatchmakingRequest
        /// </summary>
        public MatchmakingRequest() { }
    }
}
