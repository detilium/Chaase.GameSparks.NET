using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Responses
{
    public class CancelBulkJobAdminResponse : GameSparksBaseAdminReponse
    {
        [JsonProperty("bulkJobs")]
        public List<GameSparksBulkJob> BulkJobs { get; set; }
    }
}
