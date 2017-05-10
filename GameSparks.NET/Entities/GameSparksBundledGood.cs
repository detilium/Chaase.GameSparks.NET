using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksBundledGood
    {
        [JsonProperty("qty")]
        public int Quantity { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
    }
}
