using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Store.Requests
{
    public class ListVirtualGoodsRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".ListVirtualGoodsRequest"; } }
        [JsonProperty("includeDisabled")]
        public bool IncludeDisabled { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new ListVirtualGoodsRequest
        /// </summary>
        /// <param name="includeDisabled"></param>
        /// <param name="tags"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public ListVirtualGoodsRequest(bool includeDisabled, List<string> tags, string playerId, string requestId = "")
        {
            IncludeDisabled = includeDisabled;
            Tags = tags;
            PlayerId = playerId;
            RequestId = requestId;
        }

        /// <summary>
        /// Initialize a new empty ListVirtualGoodsRequest
        /// </summary>
        public ListVirtualGoodsRequest() { }
    }
}
