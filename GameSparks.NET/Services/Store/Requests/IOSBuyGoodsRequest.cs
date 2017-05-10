using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class IOSBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".IOSBuyGoodsRequest"; } }
        [JsonProperty("receipt")]
        public string Receipt { get; set; }
        [JsonProperty("sandbox")]
        public bool Sandbox { get; set; }

        /// <summary>
        /// Initialize a new IOSBuyGoodsRequest
        /// </summary>
        /// <param name="receipt"></param>
        /// <param name="sandbox"></param>
        /// <param name="currencyCode"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public IOSBuyGoodsRequest(string receipt, bool sandbox, string currencyCode, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string requestId = "")
        {
            Receipt = receipt;
            Sandbox = sandbox;
            CurrencyCode = currencyCode;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty IOSBuyGoodsRequest
        /// </summary>
        public IOSBuyGoodsRequest() { }
    }
}
