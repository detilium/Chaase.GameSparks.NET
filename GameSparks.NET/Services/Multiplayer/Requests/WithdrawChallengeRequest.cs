using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class WithdrawChallengeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".WithdrawChallengeRequest"; } }
        [JsonProperty("challengeInstanceId")]
        public string ChallengeInstanceId { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Initialize a new WithdrawChallengeRequest
        /// </summary>
        /// <param name="challengeInstanceId"></param>
        /// <param name="message"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public WithdrawChallengeRequest(string challengeInstanceId, string message, string playerId, string requestId = "")
        {
            ChallengeInstanceId = challengeInstanceId;
            Message = message;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new ampty WithdrawChallengeRequest
        /// </summary>
        public WithdrawChallengeRequest() { }
    }
}
