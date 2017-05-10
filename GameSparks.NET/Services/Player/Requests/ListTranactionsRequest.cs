using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Requests
{
    public class ListTransactionsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListTranactionsRequest"; } }
        [JsonProperty("dateFrom")]
        public DateTime DateFrom { get; set; }
        [JsonProperty("dateTo")]
        public DateTime DateTo { get; set; }
        [JsonProperty("entryCount")]
        public int EntryCount { get; set; }
        [JsonProperty("include")]
        public string Include { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListTransactionsRequest
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="entryCount"></param>
        /// <param name="include"></param>
        /// <param name="offset"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListTransactionsRequest(DateTime dateFrom, DateTime dateTo, int entryCount, string include, int offset, string playerId, string requestId = "")
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
            EntryCount = entryCount;
            Include = include;
            Offset = offset;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListTranactionsRequest
        /// </summary>
        public ListTransactionsRequest() { }
    }
}
