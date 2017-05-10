using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class TwitchConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".TwitchConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Initialize a new TwitchConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public TwitchConnectRequest(string accessToken, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccessToken = accessToken;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
