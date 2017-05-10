using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class ListAchievementsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListAchievementsRequest"; } }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListAchievementsRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListAchievementsRequest(string playerId, string requestId = "")
        {
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListAchievementsRequest
        /// </summary>
        public ListAchievementsRequest() { }
    }
}
