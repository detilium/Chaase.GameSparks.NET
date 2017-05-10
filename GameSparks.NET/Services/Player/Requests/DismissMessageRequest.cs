using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class DismissMessageRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".DismissMessageRequest"; } }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new DismissMessageRequest
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public DismissMessageRequest(string messageId, string playerId, string requestId = "")
        {
            MessageId = messageId;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new emptry DismissMessageRequest
        /// </summary>
        public DismissMessageRequest() { }
    }
}
