using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Responses
{
    public class ListTeamChatResponse : GameSparksBaseTeamsResponse
    {
        [JsonProperty("messages")]
        public List<GameSparksChatMessage> Messages { get; set; }
    }
}
