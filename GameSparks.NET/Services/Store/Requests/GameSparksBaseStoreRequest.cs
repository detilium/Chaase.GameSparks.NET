using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class GameSparksBaseStoreRequest : GameSparksBaseRequest
    {
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}
