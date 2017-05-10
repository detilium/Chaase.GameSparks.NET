using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class WindowsBuyGoodsRequest : GameSparksBaseStoreExternalRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".WindowsBuyGoodsRequest"; } }
        [JsonProperty("platform")]
        public string Platform { get; set; }
        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        /// <summary>
        /// Initialize a new WindowsBuydGoodsRequest
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="receipt"></param>
        /// <param name="subUnitPrice"></param>
        /// <param name="uniqueTransactionByPlayer"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public WindowsBuyGoodsRequest(string platform, string receipt, int subUnitPrice, bool uniqueTransactionByPlayer, string playerId, string requestId = "")
        {
            Platform = platform;
            Receipt = receipt;
            SubUnitPrice = subUnitPrice;
            UniqueTransactionByPlayer = uniqueTransactionByPlayer;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty WindowsBuyGoodsRequest
        /// </summary>
        public WindowsBuyGoodsRequest() { }
    }
}
