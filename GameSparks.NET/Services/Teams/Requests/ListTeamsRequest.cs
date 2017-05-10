using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Teams.Requests
{
    public class ListTeamsRequest : GameSparksBaseTeamsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListTeamsRequest"; } }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("teamNameFilter")]
        public string TeamNameFilter { get; set; }
        [JsonProperty("teamTypeFilter")]
        public string TeamTypeFilter { get; set; }

        /// <summary>
        /// Initialize a new ListTeamsRequest
        /// </summary>
        /// <param name="entryCount"></param>
        /// <param name="offset"></param>
        /// <param name="teamNameFilter"></param>
        /// <param name="teamTypeFilter"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListTeamsRequest(int entryCount, int offset, string teamNameFilter, string teamTypeFilter, string playerId, string requestId = "")
        {
            EntryCount = entryCount;
            Offset = offset;
            TeamNameFilter = teamNameFilter;
            TeamTypeFilter = teamTypeFilter;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListTeamsRequest
        /// </summary>
        public ListTeamsRequest() { }
    }
}
