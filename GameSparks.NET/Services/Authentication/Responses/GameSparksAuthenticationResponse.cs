using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Responses
{
    public class GameSparksAuthenticationResponse : GameSparksBaseResponse
    {
        [JsonProperty("authToken")]
        public string AuthToken { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("newPlayer")]
        public bool NewPlayer { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
        [JsonProperty("switchSummary")]
        public GameSparksSwitchSummary SwitchSummary { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
