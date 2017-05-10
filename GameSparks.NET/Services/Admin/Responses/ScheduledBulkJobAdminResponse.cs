using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Responses
{
    public class ScheduledBulkJobAdminResponse
    {
        [JsonProperty("estimatedCount")]
        public int EstimatedCount { get; set; }
        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }
}
