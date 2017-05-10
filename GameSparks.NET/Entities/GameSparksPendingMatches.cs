using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksMultiplayerPendingMatche
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("matchData")]
        public dynamic MatchData { get; set; }
        [JsonProperty("matchGroup")]
        public string MatchGroup { get; set; }
        [JsonProperty("matchShortCode")]
        public string MatchShortCode { get; set; }
        [JsonProperty("matchedPlayers")]
        public List<GameSparksMatchedPlayers> MatchedPlayers { get; set; }
        [JsonProperty("skill")]
        public int Skill { get; set; }
    }
}
