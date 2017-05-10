using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Misc.Requests
{
    public class GetUploadedRequest : GameSparksMiscRequest
    {
        [JsonProperty("@class")]
        private string ClassString { get { return ".GetUploadUrlRequest"; } }
        [JsonProperty("uploadId")]
        public string UploadId { get; set; }

        /// <summary>
        /// Initialize a new GetUploadedRequest
        /// </summary>
        /// <param name="uploadId"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public GetUploadedRequest(string uploadId, string playerId, string requestId = "")
        {
            UploadId = uploadId;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
