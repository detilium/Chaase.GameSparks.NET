using GameSparks.NET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Events.Requests
{
    public class LogEventRequest : GameSparksBaseRequest
    {
        private string ClassStr { get { return ".LogEventRequest"; } }
        public string EventKey { get; set; }
        public string PlayerId { get; set; }

        /// <summary>
        /// Initialize a new LogEventRequest
        /// </summary>
        /// <param name="eventKey"></param>
        /// <param name="playerId"></param>
        /// <param name="requestId"></param>
        public LogEventRequest(string eventKey, string playerId, string requestId = "")
        {
            EventKey = eventKey;
            PlayerId = playerId;
            RequestId = requestId;
        }
    }
}
