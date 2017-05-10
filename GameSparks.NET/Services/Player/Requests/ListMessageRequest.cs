using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class ListMessageRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListMessageRequest"; } }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("include")]
        public string Include { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListMessageRequest
        /// </summary>
        /// <param name="entryCount"></param>
        /// <param name="include"></param>
        /// <param name="offset"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListMessageRequest(int entryCount, string include, int offset, string playerId, string requestId = "")
        {
            EntryCount = entryCount;
            Include = include;
            Offset = offset;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListMessageRequest
        /// </summary>
        public ListMessageRequest() { }
    }
}
