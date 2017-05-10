using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class DropTeamRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".DropTeamRequest"; } }
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        /// <summary>
        /// Initialize a new DropTeamRequest
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="teamId"></param>
        /// <param name="teamType"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public DropTeamRequest(string ownerId, string teamId, string teamType, string playerId, string requestId = "")
        {
            OwnerId = ownerId;
            TeamId = teamId;
            TeamType = TeamType;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new DropTeamRequest
        /// </summary>
        public DropTeamRequest() { }
    }
}
