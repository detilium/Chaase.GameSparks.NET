using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Requests
{
    public class RevokePurchaseGoodsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".RevokePurchaseGoodsRequest"; } }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("storeType")]
        public string StoreType { get; set; }
        [JsonProperty("transactionIds")]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Initialize a new RevokePurchaseGoodsRequest
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="storeType"></param>
        /// <param name="transactionIds"></param>
        /// <param name="requestId"></param>
        public RevokePurchaseGoodsRequest(string playerId, string storeType, List<string> transactionIds, string authToken = "", string requestId = "")
        {
            PlayerId = playerId;
            StoreType = storeType;
            TransactionIds = transactionIds;
            AuthToken = authToken;
        }

        /// <summary>
        /// Initialize a new empty RevokePurchaseGoodsRequest
        /// </summary>
        public RevokePurchaseGoodsRequest() { }
    }
}
