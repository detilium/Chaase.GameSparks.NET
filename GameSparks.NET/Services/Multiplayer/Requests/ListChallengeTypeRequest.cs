using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class ListChallengeTypeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListChallengeTypeRequest"; } }

        /// <summary>
        /// Initialize a new ListChallengeTypeRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListChallengeTypeRequest(string playerId, string requestId = "")
        {
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListChallengeTypeRequest
        /// </summary>
        public ListChallengeTypeRequest() { }
    }
}
