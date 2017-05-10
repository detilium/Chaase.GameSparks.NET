using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksPlayer
    {
        [JsonProperty("achievements")]
        public List<string> Achievements { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("externalIds")]
        public dynamic ExternalIds { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("online")]
        public bool Online { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
        [JsonProperty("virtualGoods")]
        public List<string> VirtualGoods { get; set; }
    }
}
