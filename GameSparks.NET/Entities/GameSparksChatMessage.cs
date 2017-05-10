using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksChatMessage
    {
        [JsonProperty("fromId")]
        public string FromId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("when")]
        public DateTime When { get; set; }
        [JsonProperty("who")]
        public string Who { get; set; }
    }
}
