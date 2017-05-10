using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class AmazonConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".AmazonConnectRequest"; } }
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Initialize a new AmazonConnectRequest
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="synDisplayName"></param>
        public AmazonConnectRequest(string accessToken, bool doNotLinkToCurrentPlayer = true, bool errorOnSwitch = true, string requestId = "", dynamic segments = null, bool switchIfPossible = true, bool syncDisplayName = true)
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
