using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class GooglePlayConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GooglePlayConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("googlePlsuScope")]
        public bool GooglePlusScope { get; set; }
        [JsonProperty("profileScope")]
        public bool ProfileScope { get; set; }
        [JsonProperty("redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Initialize a new GooglePlayConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="code"></param>
        /// <param name="displayName"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="googlePlusScope"></param>
        /// <param name="profileScope"></param>
        /// <param name="redirectUri"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public GooglePlayConnectRequest(string accessToken, string code, string displayName, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, bool googlePlusScope, bool profileScope, string redirectUri, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccessToken = accessToken;
            Code = code;
            DisplayName = displayName;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            GooglePlusScope = googlePlusScope;
            ProfileScope = profileScope;
            RedirectUri = redirectUri;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
