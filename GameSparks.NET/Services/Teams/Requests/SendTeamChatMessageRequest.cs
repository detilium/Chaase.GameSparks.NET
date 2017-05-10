using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class SendTeamChatMessageRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".SendTeamChatMessageRequest"; } }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        /// <summary>
        /// Initialize a new SendTeamChatMessageRequest
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ownerId"></param>
        /// <param name="teamId"></param>
        /// <param name="teamType"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public SendTeamChatMessageRequest(string message, string ownerId, string teamId, string teamType, string playerId, string requestId = "")
        {
            Message = message;
            OwnerId = ownerId;
            TeamId = teamId;
            TeamType = teamType;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty SendTeamChatMessageRequest
        /// </summary>
        public SendTeamChatMessageRequest() { }
    }
}
