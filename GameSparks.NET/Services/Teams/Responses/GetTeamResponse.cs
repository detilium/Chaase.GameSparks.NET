using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Responses
{
    public class GetTeamResponse : GameSparksBaseTeamsResponse
    {
        [JsonProperty("memebrs")]
        public List<GameSparksPlayer> Members { get; set; }
        [JsonProperty("owner")]
        public dynamic Owner { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamName")]
        public string TeamName { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }
        [JsonProperty("teams")]
        public List<GameSparksTeam> Teams { get; set; }
    }
}
