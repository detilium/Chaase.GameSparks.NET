using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class CreateTeamRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".CreateTeamRequest"; } }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamName")]
        public string TeamName { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        /// <summary>
        /// Initialize a new CreateTeamRequest
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="teamType"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public CreateTeamRequest(string teamId, string teamName, string teamType, string playerId, string requestId = "")
        {
            TeamId = teamId;
            TeamName = teamName;
            TeamType = teamType;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty CreateTeamRequest
        /// </summary>
        public CreateTeamRequest() { }
    }
}
