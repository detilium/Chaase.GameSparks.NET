using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class SocialStatusRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".SocialStatusRequest"; } }

        /// <summary>
        /// Initialize a new SocialStatusRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public SocialStatusRequest(string playerId, string requestId = "")
        {
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
