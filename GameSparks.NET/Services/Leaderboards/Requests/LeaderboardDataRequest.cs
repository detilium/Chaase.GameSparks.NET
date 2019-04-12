using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Requests
{
    public class LeaderboardDataRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".LeaderboardDataRequest"; } }
        [JsonProperty("challengeInstanceId")]
        public string ChallengeInstanceId { get; set; }
        [JsonProperty("dontErrorOnNotSocial")]
        public bool DontErrorOnNotSocial { get; set; }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("friendIds")]
        public List<string> FriendIds { get; set; }
        [JsonProperty("includeFirst")]
        public int IncludeFirst { get; set; }
        [JsonProperty("includeLast")]
        public int IncludeLast { get; set; }
        [JsonProperty("inverseSocial")]
        public bool InverseSocial { get; set; }
        [JsonProperty("leaderboardShortCode")]
        public string LeaderboardShortCode { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("social")]
        public bool Social { get; set; }
        [JsonProperty("teamIds")]
        public List<string> TeamIds { get; set; }
        [JsonProperty("teamTypes")]
        public List<string> TeamTypes { get; set; }

        /// <summary>
        /// /Initialize a new LeaderboardDataRequest
        /// </summary>
        /// <param name="challengeInstanceId"></param>
        /// <param name="dontErrorOnNotSocial"></param>
        /// <param name="entryCount"></param>
        /// <param name="friendIds"></param>
        /// <param name="includeFirst"></param>
        /// <param name="includeLast"></param>
        /// <param name="inverseSocial"></param>
        /// <param name="leaderboardShortCode"></param>
        /// <param name="offset"></param>
        /// <param name="playerId"></param>
        /// <param name="social"></param>
        /// <param name="teamIds"></param>
        /// <param name="teamTypes"></param>
        /// <param name="requestId"></param>
        public LeaderboardDataRequest(string challengeInstanceId, bool dontErrorOnNotSocial, int entryCount, List<string> friendIds, int includeFirst, int includeLast, bool inverseSocial, string leaderboardShortCode, int offset, string playerId, bool social, List<string> teamIds, List<string> teamTypes, string requestId = "")
        {
            ChallengeInstanceId = challengeInstanceId;
            DontErrorOnNotSocial = dontErrorOnNotSocial;
            EntryCount = entryCount;
            IncludeFirst = includeFirst;
            IncludeLast = includeLast;
            InverseSocial = inverseSocial;
            LeaderboardShortCode = leaderboardShortCode;
            Offset = offset;
            PlayerId = playerId;
            Social = social;
            TeamIds = teamIds;
            TeamTypes = teamTypes;
            RequestId = requestId;
        }
    }
}
