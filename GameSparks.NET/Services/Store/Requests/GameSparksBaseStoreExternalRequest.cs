using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class GameSparksBaseStoreExternalRequest : GameSparksBaseStoreRequest
    {
        [JsonProperty("subUnitPrice")]
        public int SubUnitPrice { get; set; }
        [JsonProperty("uniqueTransactionByPlayer")]
        public bool UniqueTransactionByPlayer { get; set; }
    }
}
