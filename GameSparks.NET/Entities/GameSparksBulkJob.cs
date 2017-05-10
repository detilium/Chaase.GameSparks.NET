using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksBulkJob
    {
        [JsonProperty("actualCount")]
        public int ActualCount { get; set; }
        [JsonProperty("completed")]
        public DateTime Completed { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("data")]
        public dynamic Data { get; set; }
        [JsonProperty("doneCount")]
        public int DoneCount { get; set; }
        [JsonProperty("errorCount")]
        public int ErrorCount { get; set; }
        [JsonProperty("estimatedCount")]
        public int EstimatedCount { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("moduleShortCode")]
        public string ModuleShortCode { get; set; }
        [JsonProperty("playerQuery")]
        public dynamic PlayerQuery { get; set; }
        [JsonProperty("scheduledTime")]
        public DateTime ScheduledTime { get; set; }
        [JsonProperty("script")]
        public string Script { get; set; }
        [JsonProperty("started")]
        public DateTime Started { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
