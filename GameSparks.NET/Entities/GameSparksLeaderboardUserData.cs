using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksLeaderboardUserData
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("externalIds")]
        public dynamic ExternalIds { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("when")]
        public string When { get; set; }
    }
}
