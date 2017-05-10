using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Leaderboards.Requests
{
    public class AroundMeLeaderboardRequest : GameSparksBaseLeaderboardsRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".AroundMeLeaderboardRequest"; } }
        [JsonProperty("challengeInstanceId")]
        public string ChallengeInstanceId { get; set; }
        [JsonProperty("customIdFilter")]
        public dynamic CustomIdFilter { get; set; }
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
        [JsonProperty("social")]
        public bool Social { get; set; }
        [JsonProperty("teamIds")]
        public List<string> TeamIds { get; set; }
        [JsonProperty("teamTypes")]
        public List<string> TeamTypes { get; set; }

        /// <summary>
        /// Initialize a new AroundMeLeaderboardRequest
        /// </summary>
        /// <param name="challengeInstanceId"></param>
        /// <param name="customIdFilter"></param>
        /// <param name="dontErrorOnNotSocial"></param>
        /// <param name="entryCount"></param>
        /// <param name="friendIds"></param>
        /// <param name="includeFirst"></param>
        /// <param name="includeLast"></param>
        /// <param name="inverseSocial"></param>
        /// <param name="leaderboardShortCode"></param>
        /// <param name="social"></param>
        /// <param name="teamIds"></param>
        /// <param name="teamTypes"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public AroundMeLeaderboardRequest(string challengeInstanceId, dynamic customIdFilter, bool dontErrorOnNotSocial, int entryCount, List<string> friendIds, int includeFirst, int includeLast, bool inverseSocial, string leaderboardShortCode, bool social, List<string> teamIds, List<string> teamTypes, string playerId, string requestId = "")
        {
            ChallengeInstanceId = challengeInstanceId;
            CustomIdFilter = customIdFilter;
            DontErrorOnNotSocial = dontErrorOnNotSocial;
            EntryCount = entryCount;
            FriendIds = friendIds;
            IncludeFirst = includeFirst;
            IncludeLast = includeLast;
            InverseSocial = inverseSocial;
            LeaderboardShortCode = leaderboardShortCode;
            Social = social;
            TeamIds = teamIds;
            TeamTypes = teamTypes;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
