using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Requests
{
    public class ScheduleBulkJobAdminRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ScheduleBulkJobAdminRequest"; } }
        [JsonProperty("data")]
        public dynamic Data { get; set; }
        [JsonProperty("moduleShortCode")]
        public string ModuleShortCode { get; set; }
        [JsonProperty("playerQuery")]
        public dynamic PlayerQuery { get; set; }
        [JsonProperty("scheduledTime")]
        public DateTime ScheduledTime { get; set; }
        [JsonProperty("script")]
        public string Script { get; set; }

        /// <summary>
        /// Initialize a new ScheduleBulkJobAdminRequest
        /// </summary>
        /// <param name="data"></param>
        /// <param name="moduleShortCode"></param>
        /// <param name="playerQuery"></param>
        /// <param name="scheduledTime"></param>
        /// <param name="script"></param>
        /// <param name="requestId"></param>
        public ScheduleBulkJobAdminRequest(dynamic data, string moduleShortCode, dynamic playerQuery, DateTime scheduledTime, string script, string authToken = "", string requestId = "")
        {
            Data = data;
            ModuleShortCode = moduleShortCode;
            PlayerQuery = playerQuery;
            ScheduledTime = scheduledTime;
            Script = script;
            RequestId = requestId;
            AuthToken = authToken;
        }

        /// <summary>
        /// Initialize a new empty ScheduleBulkJobAdminRequest
        /// </summary>
        public ScheduleBulkJobAdminRequest() { }
    }
}
