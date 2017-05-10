using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class NXConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".NXConnectRequest"; } }
        [JsonProperty("accountPerLoginId")]
        public bool AccountPerLoginId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("nsaIdToken")]
        public string NSAIdToken { get; set; }

        /// <summary>
        /// Initialize a new NXConnectRequest
        /// </summary>
        /// <param name="accountPerLoginId"></param>
        /// <param name="displayName"></param>
        /// <param name="nsaIdToken"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public NXConnectRequest(bool accountPerLoginId, string displayName, string nsaIdToken, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            AccountPerLoginId = accountPerLoginId;
            DisplayName = displayName;
            NSAIdToken = nsaIdToken;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
