using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class GameSparksBaseAuthenticationRequest : GameSparksBaseRequest
    {
        [JsonProperty("segments")]
        public dynamic Segments { get; set; }
    }
}
