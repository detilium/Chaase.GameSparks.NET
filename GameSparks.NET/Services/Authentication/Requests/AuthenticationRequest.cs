using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class AuthenticationRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".AuthenticationRequest"; } }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }

        /// <summary>
        /// Initialize a new AuthenticationRequest
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="requestId"></param>
        public AuthenticationRequest(string userName, string password, dynamic scriptData = null, string requestId = "")
        {
            UserName = userName;
            Password = password;
            ScriptData = scriptData;
            RequestId = requestId;
        }
    }
}
