using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class ConsumeVirtualGoodRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ConsumeVirtualGoodRequest"; } }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }

        /// <summary>
        /// Initialize a new ConsumeVirtualGoodsRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="quantity"></param>
        /// <param name="shortCode"></param>
        /// <param name="requestId"></param>
        public ConsumeVirtualGoodRequest(string playerId, int quantity, string shortCode, string requestId = "")
        {
            PlayerId = playerId;
            Quantity = quantity;
            ShortCode = shortCode;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ConsumeVirtualGoodRequest
        /// </summary>
        public ConsumeVirtualGoodRequest() { }
    }
}
