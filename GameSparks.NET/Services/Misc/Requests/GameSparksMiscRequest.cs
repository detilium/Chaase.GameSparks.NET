using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GameSparksMiscRequest : GameSparksBaseRequest
    {
        [JsonProperty("playerID")]
        public string PlayerId { get; set; }
    }
}
