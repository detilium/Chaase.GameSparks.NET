using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksTeam
    {
        [JsonProperty("owner")]
        public dynamic Owner { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamName")]
        public string TeamName { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }
    }
}
