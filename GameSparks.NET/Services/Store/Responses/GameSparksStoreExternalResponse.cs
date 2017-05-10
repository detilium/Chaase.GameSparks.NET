using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Responses
{
    public class GameSparksStoreExternalResponse : GameSparksBaseStoreResponse
    {
        [JsonProperty("boughtItems")]
        public List<GameSparksBoughtItem> BoughtItems { get; set; }
        [JsonProperty("currency1Added")]
        public int Currency1Added { get; set; }
        [JsonProperty("currency2Added")]
        public int Currency2Added { get; set; }
        [JsonProperty("currency3Added")]
        public int Currency3Added { get; set; }
        [JsonProperty("currency4Added")]
        public int Currency4Added { get; set; }
        [JsonProperty("currency5Added")]
        public int Currency5Added { get; set; }
        [JsonProperty("currency6Added")]
        public int Currency6Added { get; set; }
        [JsonProperty("currencyConsumed")]
        public int CurrencyConsumed { get; set; }
        [JsonProperty("currencyType")]
        public int CurrencyType { get; set; }
        [JsonProperty("invalidItems")]
        public List<string> InvalidItems { get; set; }
        [JsonProperty("transactionIds")]
        public List<string> TransactionIds { get; set; }
    }
}
