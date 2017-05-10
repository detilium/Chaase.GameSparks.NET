using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class DismissMultipleMessagesRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".DismissMultipleMessagesRequest"; } }
        [JsonProperty("messageIds")]
        public List<string> MessageIds { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new DismissMultipleMessagesRequest
        /// </summary>
        /// <param name="messageIds"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public DismissMultipleMessagesRequest(List<string> messageIds, string playerId, string requestId = "")
        {
            MessageIds = messageIds;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new emptry DismissMultipleMessagesRequest
        /// </summary>
        public DismissMultipleMessagesRequest() { }
    }
}
