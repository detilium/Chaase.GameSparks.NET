using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class ViberConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ViberConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        [JsonProperty("doNotRegisterForPush")]
        public bool DoNotRegisterForPush { get; set; }

        /// <summary>
        /// Initialize a new ViberConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="doNotRegisterForPush"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public ViberConnectRequest(string accessToken, bool doNotRegisterForPush, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccessToken = accessToken;
            DoNotRegisterForPush = doNotRegisterForPush;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
