using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksChallengeInstance
    {
        [JsonProperty("accepted")]
        public List<GameSparksChallengeUserData> Accepted { get; set; }
        [JsonProperty("challengeId")]
        public string ChallengeId { get; set; }
        [JsonProperty("challengeMessage")]
        public string ChallengeMessage { get; set; }
        [JsonProperty("challengeName")]
        public string ChallengeName { get; set; }
        [JsonProperty("challenged")]
        public List<GameSparksChallengeUserData> Challenged { get; set; }
        [JsonProperty("challenger")]
        public GameSparksChallengeUserData Challenger { get; set; }
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
        [JsonProperty("declined")]
        public List<GameSparksChallengeUserData> Declined { get; set; }
        [JsonProperty("endDate")]
        public DateTime EndDate { get; set; }
        [JsonProperty("expiryDate")]
        public DateTime ExpiryDate { get; set; }
        [JsonProperty("maxTurns")]
        public int MaxTurns { get; set; }
        [JsonProperty("nextPlayer")]
        public string NextPlayer { get; set; }
        [JsonProperty("scriptData")]
        public dynamic ScriptData { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("turnCount")]
        public List<GameSparksChallengeTurnCount> TurnCount { get; set; }
    }
}
