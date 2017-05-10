using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class ListGameFriendsResponse : GameSparksBasePlayerResponse
    {
        [JsonProperty("friends")]
        public List<GameSparksPlayer> Friends { get; set; }
    }
}
