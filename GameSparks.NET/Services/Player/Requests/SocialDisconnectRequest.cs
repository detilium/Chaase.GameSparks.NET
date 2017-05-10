using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class SocialDisconnectRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".SocialDisconnectRequest"; } }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("systemId")]
        public string SystemId { get; set; }

        /// <summary>
        /// Initialize a new SocialDisconnectRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="systemId"></param>
        /// <param name="requestId"></param>
        public SocialDisconnectRequest(string playerId, string systemId, string requestId = "")
        {
            PlayerId = playerId;
            SystemId = systemId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty SocialDisconnectRequest
        /// </summary>
        public SocialDisconnectRequest() { }
    }
}
