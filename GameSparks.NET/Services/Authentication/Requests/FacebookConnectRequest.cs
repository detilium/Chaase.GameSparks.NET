using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class FacebookConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".FacebookConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Initialize a new FacebookConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="code"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public FacebookConnectRequest(string accessToken, string code, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccessToken = accessToken;
            Code = code;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
            RequestId = requestId;
        }
    }
}
