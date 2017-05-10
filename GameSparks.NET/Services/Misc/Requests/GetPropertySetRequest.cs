using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GetPropertySetRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".GetPropertySetRequest"; } }
        [JsonProperty("")]
        public string PropertySetShortCode { get; set; }

        /// <summary>
        /// Initialize a new GetPropertySetRequest
        /// </summary>
        /// <param name="propertySetShortCode"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetPropertySetRequest(string propertySetShortCode, string playerId, string requestId = "")
        {
            PropertySetShortCode = propertySetShortCode;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
