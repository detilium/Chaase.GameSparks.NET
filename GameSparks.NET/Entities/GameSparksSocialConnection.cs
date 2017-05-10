using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksSocialConnection
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }
        [JsonProperty("systemId")]
        public string SystemId { get; set; }
    }
}
