using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class ListMessageSummaryRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListMessageSummaryRequest"; } }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListMessageSummaryRequest
        /// </summary>
        /// <param name="entryCount"></param>
        /// <param name="offset"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListMessageSummaryRequest(int entryCount, int offset, string playerId, string requestId = "")
        {
            EntryCount = entryCount;
            Offset = offset;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListMessageSummaryRequest
        /// </summary>
        public ListMessageSummaryRequest() { }
    }
}
