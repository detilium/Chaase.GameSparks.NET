using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksMessage
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("message")]
        public dynamic Message { get; set; }
        [JsonProperty("seen")]
        public bool Seen { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("when")]
        public DateTime When { get; set; }
    }
}
