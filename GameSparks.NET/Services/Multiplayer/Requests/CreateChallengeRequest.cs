using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class CreateChallengeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".CreateChallengeRequest"; } }
        [JsonProperty("accessType")]
        public string AccessType { get; set; }
        [JsonProperty("autoStartJoinedChallengeOnMaxPlayers")]
        public bool AutoStartJoinedChallengeOnMaxPlayers { get; set; }
        [JsonProperty("challengeMessage")]
        public string ChallengeMessage { get; set; }
        [JsonProperty("challengeShortCode")]
        public string ChallengeShortCode { get; set; }
        [JsonProperty("currency1Wager")]
        public int Currency1Wager { get; set; }
        [JsonProperty("currency2Wager")]
        public int Currency2Wager { get; set; }
        [JsonProperty("currency3Wager")]
        public int Currency3Wager { get; set; }
        [JsonProperty("currency4Wager")]
        public int Currency4Wager { get; set; }
        [JsonProperty("currency5Wager")]
        public int Currency5Wager { get; set; }
        [JsonProperty("currency6Wager")]
        public int Currency6Wager { get; set; }
        [JsonProperty("eligibilityCriteria")]
        public dynamic EligibilityCriteria { get; set; }
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }
        [JsonProperty("expiryTime")]
        public DateTime ExpiryTime { get; set; }
        [JsonProperty("maxAttempts")]
        public int MaxAttempts { get; set; }
        [JsonProperty("maxPlayers")]
        public int MaxPlayers { get; set; }
        [JsonProperty("minPlayers")]
        public int MinPlayers { get; set; }
        [JsonProperty("silent")]
        public bool Silent { get; set; }
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }
        [JsonProperty("usersToChallenge")]
        public List<string> UsersToChallenge { get; set; }

        /// <summary>
        /// Initialize a new CreateChallengeRequest
        /// </summary>
        /// <param name="accessType"></param>
        /// <param name="autoStartJoinedChallengeOnMaxPlayers"></param>
        /// <param name="challengeMessage"></param>
        /// <param name="challengeShortCode"></param>
        /// <param name="currency1Wager"></param>
        /// <param name="currency2Wager"></param>
        /// <param name="currency3Wager"></param>
        /// <param name="currency4Wager"></param>
        /// <param name="currency5Wager"></param>
        /// <param name="currency6Wager"></param>
        /// <param name="eligibilityCriteria"></param>
        /// <param name="endTime"></param>
        /// <param name="expiryTime"></param>
        /// <param name="maxAttempts"></param>
        /// <param name="maxPlayers"></param>
        /// <param name="minPlayers"></param>
        /// <param name="silent"></param>
        /// <param name="startTime"></param>
        /// <param name="usersToChallenge"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public CreateChallengeRequest(string accessType, bool autoStartJoinedChallengeOnMaxPlayers, string challengeMessage, string challengeShortCode, int currency1Wager, int currency2Wager, int currency3Wager, int currency4Wager, int currency5Wager, int currency6Wager, dynamic eligibilityCriteria, DateTime endTime, DateTime expiryTime, int maxAttempts, int maxPlayers, int minPlayers, bool silent, DateTime startTime, List<string> usersToChallenge, string playerId, string requestId = "")
        {
            AccessType = accessType;
            AutoStartJoinedChallengeOnMaxPlayers = autoStartJoinedChallengeOnMaxPlayers;
            ChallengeMessage = challengeMessage;
            ChallengeShortCode = challengeShortCode;
            Currency1Wager = currency1Wager;
            Currency2Wager = currency2Wager;
            Currency3Wager = currency3Wager;
            Currency4Wager = currency4Wager;
            Currency5Wager = currency5Wager;
            Currency6Wager = currency6Wager;
            EligibilityCriteria = eligibilityCriteria;
            EndTime = endTime;
            ExpiryTime = expiryTime;
            MaxAttempts = maxAttempts;
            MaxPlayers = maxPlayers;
            MinPlayers = minPlayers;
            Silent = silent;
            StartTime = startTime;
            UsersToChallenge = usersToChallenge;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty CreateChallengeRequest
        /// </summary>
        public CreateChallengeRequest() { }
    }
}
