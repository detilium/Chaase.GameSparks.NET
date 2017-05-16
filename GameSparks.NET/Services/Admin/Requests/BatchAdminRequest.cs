using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Requests
{
    public class BatchAdminRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".BatchAdminRequest"; } }
        [JsonProperty("playerIds")]
        public List<string> PlayerIds { get; set; }
        [JsonProperty("request")]
        public dynamic Request { get; set; }

        /// <summary>
        /// Initialize a new BatchAdminRequest
        /// </summary>
        /// <param name="playerIds"></param>
        /// <param name="request"></param>
        /// <param name="requestId"></param>
        public BatchAdminRequest(List<string> playerIds, dynamic request, string authToken = "", string requestId = "")
        {
            PlayerIds = playerIds;
            Request = requestId;
            RequestId = requestId;
            AuthToken = authToken;
        }

        /// <summary>
        /// Initialize a new empty BatchAdminRequest
        /// </summary>
        public BatchAdminRequest() { }
    }
}
