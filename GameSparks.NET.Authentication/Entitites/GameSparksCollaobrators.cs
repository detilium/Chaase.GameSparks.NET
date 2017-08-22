using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Entitites
{
    public class GameSparksCollaborator
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("groupNames")]
        public List<string> GroupNames { get; set; }
    }
}
