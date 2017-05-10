using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class GameSparksConnectRequest : GameSparksBaseAuthenticationRequest
    {
        [JsonProperty("doNotLinkToCurrentPlayer")]
        public bool DoNotLinkToCurrentPlayer { get; set; }
        [JsonProperty("errorOnSwitch")]
        public bool ErrorOnSwitch { get; set; }
        [JsonProperty("switchIfPossible")]
        public bool SwitchIfPossible { get; set; }
        [JsonProperty("syncDisplayName")]
        public bool SyncDisplayName { get; set; }
    }
}
