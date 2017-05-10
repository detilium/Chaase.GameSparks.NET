using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GetDownloadableRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GetDownloadableRequest"; } }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }

        /// <summary>
        /// Initialize a new GetDownloadableRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="shortCode"></param>
        /// <param name="requestId"></param>
        public GetDownloadableRequest(string playerId, string shortCode, string requestId = "")
        {
            PlayerId = playerId;
            ShortCode = shortCode;
            RequestId = requestId;
        }
    }
}
