using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Responses
{
    public class GetPropertyResponse : GameSparksBaseMiscResponse
    {
        [JsonProperty("property")]
        public dynamic Property { get; set; }
    }
}
