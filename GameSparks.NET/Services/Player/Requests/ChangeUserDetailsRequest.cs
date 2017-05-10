using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class ChangeUserDetailsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ChangeUserDetailsRequest"; } }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Initialize a new ChangeUserDetailsRequest
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="language"></param>
        /// <param name="newPassword"></param>
        /// <param name="oldPassword"></param>
        /// <param name="playerId"></param>
        /// <param name="userName"></param>
        /// <param name="requestId"></param>
        public ChangeUserDetailsRequest(string displayName, string language, string newPassword, string oldPassword, string playerId, string userName, string requestId = "")
        {
            DisplayName = displayName;
            Language = language;
            NewPassword = newPassword;
            OldPassword = oldPassword;
            PlayerId = playerId;
            UserName = userName;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new emptry ChangeUserDetailsRequest
        /// </summary>
        public ChangeUserDetailsRequest() { }

    }
}
