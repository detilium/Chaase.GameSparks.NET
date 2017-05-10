using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class SendFriendMessageRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".SendFriendMessageRequest"; } }
        [JsonProperty("friendIds")]
        public List<string> FriendIds { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new SendFriendMessageRequest
        /// </summary>
        /// <param name="friendIds"></param>
        /// <param name="message"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public SendFriendMessageRequest(List<string> friendIds, string message, string playerId, string requestId = "")
        {
            FriendIds = friendIds;
            Message = message;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty SendFriendMessageRequest
        /// </summary>
        public SendFriendMessageRequest() { }
    }
}
