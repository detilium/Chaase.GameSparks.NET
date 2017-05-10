using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class GetTeamRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GetTeamRequest"; } }
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        /// <summary>
        /// Initialize a new GetTeamRequest
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="teamId"></param>
        /// <param name="teamType"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetTeamRequest(string ownerId, string teamId, string teamType, string playerId, string requestId ="")
        {
            OwnerId = ownerId;
            TeamId = teamId;
            TeamType = teamType;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Inititialize a new empty GetTeamRequest
        /// </summary>
        public GetTeamRequest() { }
    }
}
