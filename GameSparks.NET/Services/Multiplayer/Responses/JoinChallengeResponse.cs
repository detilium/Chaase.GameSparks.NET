using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Responses
{
    public class JoinChallengeResponse : GameSparksBaseMultiplayerResponse
    {
        [JsonProperty("joined")]
        public bool Joined { get; set; }
    }
}
