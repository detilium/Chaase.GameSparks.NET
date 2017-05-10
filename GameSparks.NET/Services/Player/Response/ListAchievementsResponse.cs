using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class ListAchievementsResponse : GameSparksBasePlayerResponse
    {
        [JsonProperty("achievements")]
        public List<GameSparksAchievement> Achievements { get; set; }
    }
}
