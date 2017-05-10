using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class FindChallengeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".FindChallengeRequest"; } }
        [JsonProperty("accessType")]
        public string AccessType { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("eligibility")]
        public dynamic Eligibility { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("shortCode")]
        public List<string> ShortCode { get; set; }

        /// <summary>
        /// Initialize a new FindChallengeRequest
        /// </summary>
        /// <param name="accessType"></param>
        /// <param name="count"></param>
        /// <param name="eligibility"></param>
        /// <param name="offset"></param>
        /// <param name="shortCode"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public FindChallengeRequest(string accessType, int count, dynamic eligibility, int offset, List<string> shortCode, string playerId, string requestId = "")
        {
            AccessType = accessType;
            Count = count;
            Eligibility = eligibility;
            Offset = offset;
            ShortCode = shortCode;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty FindChallengeRequest
        /// </summary>
        public FindChallengeRequest() { }
    }
}
