using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Responses
{
    public class MatchDetailsResponse : GameSparksBaseMultiplayerResponse
    {
        [JsonProperty("accesToken")]
        public string AccessToken { get; set; }
        [JsonProperty("host")]
        public string Host { get; set; }
        [JsonProperty("matchData")]
        public dynamic MatchData { get; set; }
        [JsonProperty("matchId")]
        public string MatchId { get; set; }
        [JsonProperty("opponents")]
        public List<GameSparksPlayer> Opponents { get; set; }
        [JsonProperty("peerId")]
        public int PeerId { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("post")]
        public int Port { get; set; }
    }
}
