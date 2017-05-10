using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class GooglePlusConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GooglePlayConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("redirectUri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Initialize a new GooglePlusConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="code"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="redirectUri"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public GooglePlusConnectRequest(string accessToken, string code, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, string redirectUri, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccessToken = accessToken;
            Code = code;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RedirectUri = redirectUri;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
