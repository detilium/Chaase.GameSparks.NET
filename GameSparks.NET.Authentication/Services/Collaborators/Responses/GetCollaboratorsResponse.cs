using GameSparks.NET.Authentication.Entitites;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Services.Collaborators.Responses
{
    public class GetCollaboratorsResponse
    {
        [JsonProperty("collaborators")]
        public List<GameSparksCollaborator> Collaborators { get; set; }
        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}
