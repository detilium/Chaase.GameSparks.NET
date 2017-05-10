using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class AmazonBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".AmazonBuyGoodsRequest"; } }
        [JsonProperty("amazonUserId")]
        public string AmazonUserId { get; set; }
        [JsonProperty("receiptId")]
        public string ReceiptId { get; set; }

        /// <summary>
        /// Initialize a new AmazonBuyGoodsRequest
        /// </summary>
        /// <param name="amazonUserId"></param>
        /// <param name="receiptId"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="currencyCode"></param>
        /// <param name="requestId"></param>
        public AmazonBuyGoodsRequest(string amazonUserId, string receiptId, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string currencyCode, string requestId = "")
        {
            AmazonUserId = amazonUserId;
            ReceiptId = receiptId;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            CurrencyCode = currencyCode;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty AmazonBuyGoodsRequest
        /// </summary>
        public AmazonBuyGoodsRequest() { }
    }
}
