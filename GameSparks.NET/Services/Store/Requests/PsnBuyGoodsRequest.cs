using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class PsnBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".PsnBuyGoodsRequest"; } }
        [JsonProperty("authorizationCode")]
        public string AuthorizationCode { get; set; }
        [JsonProperty("entitlementLabel")]
        public string EntitlementLabel { get; set; }
        [JsonProperty("redirectUrl")]
        public string RedirectUri { get; set; }
        [JsonProperty("useCount")]
        public int UseCount { get; set; }

        /// <summary>
        /// Initialize a new PsnBuyGoodsRequest
        /// </summary>
        /// <param name="authorizationCode"></param>
        /// <param name="entitlementLabel"></param>
        /// <param name="redirectUri"></param>
        /// <param name="useCounbt"></param>
        /// <param name="currencyCode"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public PsnBuyGoodsRequest(string authorizationCode, string entitlementLabel, string redirectUri, int useCount, string currencyCode, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string requestId = "")
        {
            AuthorizationCode = authorizationCode;
            EntitlementLabel = entitlementLabel;
            RedirectUri = redirectUri;
            UseCount = useCount;
            CurrencyCode = currencyCode;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty PsnBuyGoodsRequest
        /// </summary>
        public PsnBuyGoodsRequest() { }
    }
}
