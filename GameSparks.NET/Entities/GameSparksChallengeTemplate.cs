using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksChallengeTemplate
    {
        [JsonProperty("challengeShortCode")]
        public string ChallengeShortCode { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("getleaderboardName")]
        public string GetLeaderboardName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
    }
}
