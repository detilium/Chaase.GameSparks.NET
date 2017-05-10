using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Multiplayer.Requests
{
    public class ListChallengeRequest : GameSparksBaseMultiplayerRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListChallengeRequest"; } }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("states")]
        public List<string> States { get; set; }

        /// <summary>
        /// Initialize a new ListChallengeRequest
        /// </summary>
        /// <param name="entryCount"></param>
        /// <param name="offset"></param>
        /// <param name="shortCode"></param>
        /// <param name="state"></param>
        /// <param name="states"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListChallengeRequest(int entryCount, int offset, string shortCode, string state, List<string> states, string playerId, string requestId = "")
        {
            EntryCount = entryCount;
            Offset = offset;
            ShortCode = shortCode;
            State = state;
            States = states;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListChallengeRequest
        /// </summary>
        public ListChallengeRequest() { } 
    }
}
