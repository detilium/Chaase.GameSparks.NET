using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Requests
{
    public class CancelBulkJobAdminRequest : GameSparksBaseRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".CancelBulkJobAdminRequest"; } }
        [JsonProperty("bulkJobIds")]
        public List<string> BulkJobIds { get; set; }

        /// <summary>
        /// Initialize a new CancelBulkJobAdminRequest
        /// </summary>
        /// <param name="bulkJobIds"></param>
        /// <param name="requestId"></param>
        public CancelBulkJobAdminRequest(List<string> bulkJobIds, string authToken = "", string requestId = "")
        {
            BulkJobIds = bulkJobIds;
            RequestId = requestId;
            AuthToken = authToken;
        }

        /// <summary>
        /// Initialize a new empty CancelBulkJobAdminRequest
        /// </summary>
        public CancelBulkJobAdminRequest() { }
    }
}
