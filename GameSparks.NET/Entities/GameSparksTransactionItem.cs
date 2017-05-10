using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksTransactionItem
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("newValue")]
        public int NewValue { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
