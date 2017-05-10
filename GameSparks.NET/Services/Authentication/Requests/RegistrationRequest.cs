using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class RegistrationRequest 
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".RegistrationRequest"; } }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        [JsonProperty("segments")]
        public dynamic Segments { get; set; }

        /// <summary>
        /// Initialize a new RegistrationRequest
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="password"></param>
        /// <param name="userName"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        public RegistrationRequest(string displayName, string password, string userName, dynamic segments, string requestId = "")
        {
            DisplayName = displayName;
            Password = password;
            UserName = userName;
            RequestId = requestId;
            Segments = segments;
        }
    }
}
