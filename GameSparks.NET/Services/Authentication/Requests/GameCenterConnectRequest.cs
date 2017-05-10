using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class GameCenterConnectRequest : GameSparksConnectRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GameCenterConnectRequest"; } }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("doNotLinkToCurrentPlayer")]
        public string ExternalPlayerId { get; set; }
        [JsonProperty("publicKeyUrl")]
        public string PublicKeyUrl { get; set; }
        [JsonProperty("salt")]
        public string Salt { get; set; }
        [JsonProperty("signature")]
        public string Signature { get; set; }
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        /// <summary>
        /// Initialize a new GameCenterConnectRequest
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="externalPlayerId"></param>
        /// <param name="publicKeyUrl"></param>
        /// <param name="salt"></param>
        /// <param name="segments"></param>
        /// <param name="signature"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        /// <param name="timestamp"></param>
        public GameCenterConnectRequest(string displayName, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, string externalPlayerId, string publicKeyUrl, string salt, dynamic segments, string signature, bool switchIfPossible, bool syncDisplayName, int timestamp, string requestId = "")
        {
            DisplayName = displayName;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            ExternalPlayerId = externalPlayerId;
            PublicKeyUrl = publicKeyUrl;
            Salt = salt;
            Segments = segments;
            Signature = signature;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
            Timestamp = timestamp;
            RequestId = requestId;
        }
    }
}
