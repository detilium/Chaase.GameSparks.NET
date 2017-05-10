using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksChallengeTurnCount
    {
        [JsonProperty("count")]
        public string Count { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
    }
}
