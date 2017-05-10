using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class JoinChallengeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".JoinChallengeRequest"; } }
        [JsonProperty("challengeInstanceId")]
        public string ChallengeInstanceId { get; set; }
        [JsonProperty("eligibility")]
        public dynamic Eligibility { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Initialize a new JoinChallengeRequest
        /// </summary>
        /// <param name="challengeInstanceId"></param>
        /// <param name="eligibility"></param>
        /// <param name="message"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public JoinChallengeRequest(string challengeInstanceId, dynamic eligibility, string message, string playerId, string requestId = "")
        {
            ChallengeInstanceId = challengeInstanceId;
            Eligibility = eligibility;
            Message = message;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty JoinChallengeRequest
        /// </summary>
        public JoinChallengeRequest() { }
    }
}
