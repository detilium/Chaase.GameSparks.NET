using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class GetMyTeamsRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GetMyTeamsRequest"; } }
        [JsonProperty("ownedOnly")]
        public bool OwnedOnly { get; set; }
        [JsonProperty("teamTypes")]
        public List<string> TeamTypes { get; set; }

        /// <summary>
        /// Initialize a new GetMyTeamsRequest
        /// </summary>
        /// <param name="ownedOnly"></param>
        /// <param name="teamTypes"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetMyTeamsRequest(bool ownedOnly, List<string> teamTypes, string playerId, string requestId = "")
        {
            OwnedOnly = ownedOnly;
            TeamTypes = teamTypes;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty GetMyTeamsRequest
        /// </summary>
        public GetMyTeamsRequest() { } 
    }
}
