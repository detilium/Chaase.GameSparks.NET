using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Requests
{
    public class ListLeaderboardsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ""; } }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListLeaderboardsRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListLeaderboardsRequest(string playerId, string requestId = "")
        {
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
