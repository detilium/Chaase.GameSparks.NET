using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksLeaderboardData
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("propertySet")]
        public dynamic PropertySet { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
    }
}
