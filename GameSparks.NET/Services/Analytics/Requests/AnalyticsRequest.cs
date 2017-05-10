using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Analytics.Requests
{
    public class AnalyticsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".AnalyticsRequest"; } }
        [JsonProperty("data")]
        public dynamic Data { get; set; }
        [JsonProperty("end")]
        public bool End { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("start")]
        public bool Start { get; set; }

        /// <summary>
        /// Initialize a new AnalyticsRequest
        /// </summary>
        /// <param name="data"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="start"></param>
        /// <param name="requestId"></param>
        public AnalyticsRequest(dynamic data, bool end, string key, bool start, string requestId = "")
        {
            Data = data;
            End = end;
            Key = key;
            Start = start;
            RequestId = requestId;
        }
    }
}
