using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Entitites
{
    public class GameSparksRepository
    {
        [JsonProperty("owner")]
        public string Owner { get; set; }
        [JsonProperty("owner")]
        public string Repo { get; set; }
    }
}
