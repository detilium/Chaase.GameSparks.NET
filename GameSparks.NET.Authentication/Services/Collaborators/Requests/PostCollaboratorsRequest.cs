using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSparks.NET.Authentication.Services.Collaborators.Requests
{
    public class PostCollaboratorsRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("groupNames")]
        public List<string> GroupNames { get; set; }

        /// <summary>
        /// Initialize a new PostCollaboratorsRequest
        /// </summary>
        /// <param name="email"></param>
        /// <param name="groupNames"></param>
        public PostCollaboratorsRequest(string email, List<string> groupNames)
        {
            Email = email;
            GroupNames = groupNames;
        }

        /// <summary>
        /// Initialize a new empty PostCollaboratorsRequest
        /// </summary>
        public PostCollaboratorsRequest() { }
    }
}
