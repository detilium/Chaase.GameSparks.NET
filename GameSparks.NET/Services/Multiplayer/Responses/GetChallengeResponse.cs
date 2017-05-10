using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Responses
{
    public class GetChallengeResponse : GameSparksBaseMultiplayerResponse
    {
        [JsonProperty("challenge")]
        public GameSparksChallengeInstance Challenge { get; set; }
    }
}
