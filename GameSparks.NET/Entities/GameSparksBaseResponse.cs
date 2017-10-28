using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksBaseResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        [JsonProperty("error")]
        public dynamic Error { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
    }
}
