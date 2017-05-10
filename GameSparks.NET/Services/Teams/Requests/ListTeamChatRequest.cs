using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class ListTeamChatRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListTeamChatRequest"; } }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
        [JsonProperty("teamType")]
        public string TeamType { get; set; }

        /// <summary>
        /// Initialize a new ListTeamChatRequest
        /// </summary>
        /// <param name="entryCount"></param>
        /// <param name="offset"></param>
        /// <param name="ownerId"></param>
        /// <param name="teamId"></param>
        /// <param name="teamType"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListTeamChatRequest(int entryCount, int offset, string ownerId, string teamId, string teamType, string playerId, string requestId = "")
        {
            EntryCount = entryCount;
            Offset = offset;
            OwnerId = ownerId;
            TeamId = teamId;
            TeamType = teamType;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty LeaveTeamRequest
        /// </summary>
        public ListTeamChatRequest() { }
    }
}
