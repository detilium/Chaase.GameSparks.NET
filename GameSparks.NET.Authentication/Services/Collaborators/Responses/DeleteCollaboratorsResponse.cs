using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Services.Collaborators.Responses
{
    public class DeleteCollaboratorsResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
