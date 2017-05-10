using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class BuyVirtualGoodsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".BuyVirtualGoodsRequest"; } }
        [JsonProperty("currencyType")]
        public int CurrencyType { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new BuyVirtualGoodsRequest
        /// </summary>
        /// <param name="currencyType"></param>
        /// <param name="quantity"></param>
        /// <param name="shortCode"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public BuyVirtualGoodsRequest(int currencyType, int quantity, string shortCode, string playerId, string requestId = "")
        {
            CurrencyType = currencyType;
            Quantity = quantity;
            ShortCode = shortCode;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty BuyVirtualGoodsRequest
        /// </summary>
        public BuyVirtualGoodsRequest() { }
    }
}
