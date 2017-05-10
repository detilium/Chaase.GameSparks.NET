using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class UpdateMessageRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".UpdateMessageRequest"; } }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// Initialize a new UpdateMessageRequest
        /// </summary>
        /// <param name="messageId"></param>
        /// <param name="playerId"></param>
        /// <param name="status"></param>
        /// <param name="requestId"></param>
        public UpdateMessageRequest(string messageId, string playerId, string status, string requestId = "")
        {
            MessageId = messageId;
            PlayerId = playerId;
            Status = status;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty UpdateMessageRequest
        /// </summary>
        public UpdateMessageRequest() { }
    }
}
