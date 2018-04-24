using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksLocation
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("latitide")]
        public double Latitide { get; set; }
        [JsonProperty("longditute")]
        public double Longditute { get; set; }
    }
}
