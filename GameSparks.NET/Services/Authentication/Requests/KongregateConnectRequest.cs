using GameSparks.NET.Services.Authentication.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class KongregateConnectRequest : GameSparksConnectRequest
    {
        private string ClassStr { get { return ".KongregateConnectRequest"; } }
        public string GameAuthToken { get; set; }
        public string UserId { get; set; }

        /// <summary>
        /// Initialize a new KongregateConnectRequest
        /// </summary>
        /// <param name="gameAuthToken"></param>
        /// <param name="userId"></param>
        /// <param name="doNotLinkToCurrentPlayer"></param>
        /// <param name="errorOnSwitch"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        /// <param name="switchIfPossible"></param>
        /// <param name="syncDisplayName"></param>
        public KongregateConnectRequest(string gameAuthToken, string userId, bool doNotLinkToCurrentPlayer, bool errorOnSwitch, dynamic segments, bool switchIfPossible, bool syncDisplayName, string requestId = "")
        {
            GameAuthToken = gameAuthToken;
            UserId = userId;
            DoNotLinkToCurrentPlayer = doNotLinkToCurrentPlayer;
            ErrorOnSwitch = errorOnSwitch;
            RequestId = requestId;
            Segments = segments;
            SwitchIfPossible = switchIfPossible;
            SyncDisplayName = syncDisplayName;
        }
    }
}
