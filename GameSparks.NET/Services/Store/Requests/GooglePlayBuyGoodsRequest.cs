using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class GooglePlayBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".GooglePlayBuyGoodsRequest"; } }
        [JsonProperty("signature")]
        public string Signature { get; set; }
        [JsonProperty("signedData")]
        public string SignedData { get; set; }

        /// <summary>
        /// Initialize a new GooglePlayBuyGoodsRequest
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="signedData"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GooglePlayBuyGoodsRequest(string signature, string signedData, string currencyCode, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string requestId = "")
        {
            Signature = signature;
            SignedData = signedData;
            CurrencyCode = currencyCode;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty GooglePlayBuyGoodsRequest
        /// </summary>
        public GooglePlayBuyGoodsRequest() { }
    }
}
