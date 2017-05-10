using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class XBOXLiveConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".XBOXLiveConnectRequest"; } }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("stsTokenString")]
        public string STSTokenString { get; set; }

        /// <summary>
        /// Initialize a new XBOXLiveConnectRequest
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="stsTokenString"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public XBOXLiveConnectRequest(string displayName, string stsTokenString, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            DisplayName = displayName;
            STSTokenString = stsTokenString;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
