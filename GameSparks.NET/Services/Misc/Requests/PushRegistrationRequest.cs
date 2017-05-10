using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class PushRegistrationRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".PushRegistrationRequest"; } }
        [JsonProperty("deviceOS")]
        public string DeviceOS { get; set; }
        [JsonProperty("pushId")]
        public string PushId { get; set; }

        /// <summary>
        /// Initialize a new PushRegistrationRequest
        /// </summary>
        /// <param name="deviceOs"></param>
        /// <param name="pushId"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public PushRegistrationRequest(string deviceOs, string pushId, string playerId, string requestId = "")
        {
            DeviceOS = deviceOs;
            PushId = pushId;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
