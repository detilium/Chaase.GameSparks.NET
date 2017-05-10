using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksMatchedPlayers
    {
        [JsonProperty("location")]
        public dynamic Location { get; set; }
        [JsonProperty("participantData")]
        public dynamic ParticipantData { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("skill")]
        public int Skill { get; set; }
    }
}
