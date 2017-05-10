using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class SteamBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".SteamBuyGoodsRequest"; } }
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Initialize a new SteamBuyGoodsRequest
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="currencyCode"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public SteamBuyGoodsRequest(string orderId, string currencyCode, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string requestId = "")
        {
            OrderId = orderId;
            CurrencyCode = currencyCode;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty SteamBuyGoodsRequest
        /// </summary>
        public SteamBuyGoodsRequest() { }
    }
}
