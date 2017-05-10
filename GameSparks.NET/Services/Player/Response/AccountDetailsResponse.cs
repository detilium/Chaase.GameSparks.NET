using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class AccountDetailsResponse : GameSparksBaseResponse
    {
        [JsonProperty("achievements")]
        public List<string> Achievements { get; set; }
        [JsonProperty("currency1")]
        public int Currency1 { get; set; }
        [JsonProperty("currency2")]
        public int Currency2 { get; set; }
        [JsonProperty("currency3")]
        public int Currency3 { get; set; }
        [JsonProperty("currency4")]
        public int Currency4 { get; set; }
        [JsonProperty("currency5")]
        public int Currency5 { get; set; }
        [JsonProperty("currency6")]
        public int Currency6 { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("externalIds")]
        public dynamic ExternalIds { get; set; }
        [JsonProperty("location")]
        public GameSparksLocation Location { get; set; }
        [JsonProperty("reservedCurrency1")]
        public dynamic ReservedCurrency1 { get; set; }
        [JsonProperty("reservedCurrency2")]
        public dynamic ReservedCurrency2 { get; set; }
        [JsonProperty("reservedCurrency3")]
        public dynamic ReservedCurrency3 { get; set; }
        [JsonProperty("reservedCurrency4")]
        public dynamic ReservedCurrency4 { get; set; }
        [JsonProperty("reservedCurrency5")]
        public dynamic ReservedCurrency5 { get; set; }
        [JsonProperty("reservedCurrency6")]
        public dynamic ReservedCurrency6 { get; set; }
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("virtualGoods")]
        public dynamic VirtualGoods { get; set; }
    }
}
