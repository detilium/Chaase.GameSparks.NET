using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Responses
{
    public class GameSparksBaseMultiplayerResponse : GameSparksBaseResponse
    {
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
    }
}
