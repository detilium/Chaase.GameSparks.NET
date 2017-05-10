using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Responses
{
    public class GetDownloadableResponse : GameSparksBaseMiscResponse
    {
        [JsonProperty("lastModified")]
        public DateTime LastModified { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
        [JsonProperty("size")]
        public int Size { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
