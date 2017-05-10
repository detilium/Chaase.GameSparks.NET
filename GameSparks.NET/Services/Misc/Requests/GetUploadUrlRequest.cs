using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GetUploadUrlRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".GetUploadUrlRequest"; } }
        [JsonProperty("uploadData")]
        public dynamic UploadData { get; set; }

        /// <summary>
        /// Initialize a new GetUploadUrlRequest
        /// </summary>
        /// <param name="uploadData"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetUploadUrlRequest(dynamic uploadData, string playerId, string requestId = "")
        {
            UploadData = uploadData;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
