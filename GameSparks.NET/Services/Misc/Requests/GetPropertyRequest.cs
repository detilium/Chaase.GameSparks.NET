using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GetPropertyRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".GetPropertyRequest"; } }
        [JsonProperty("propertShortCode")]
        public string PropertyShortCode { get; set; }

        /// <summary>
        /// Initialize a new GetPropertyRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="propertyShortCode"></param>
        /// <param name="requestId"></param>
        public GetPropertyRequest(string playerId, string propertyShortCode, string requestId = "")
        {
            PlayerId = playerId;
            PropertyShortCode = propertyShortCode;
            RequestId = requestId;
        }
    }
}
