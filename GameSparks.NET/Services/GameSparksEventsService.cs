using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Events.Requests;
using GameSparks.NET.Services.Events.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksEventsService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new LogChallengeEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public EventsResponse LogChallengeEventRequest(LogChallengeEventRequest requestData)
        {
            return JsonConvert.DeserializeObject<EventsResponse>(Requestor.PostString(Urls.LogChallengeEventRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LogEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public EventsResponse LogEventRequest(dynamic requestData)
        {
            return JsonConvert.DeserializeObject<EventsResponse>(Requestor.PostString(Urls.LogEventRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LogEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public EventsResponse LogEventRequest(string requestData)
        {
            return JsonConvert.DeserializeObject<EventsResponse>(Requestor.PostString(Urls.LogEventRequest,requestData).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous LogChallengeEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<EventsResponse> LogChallengeEventRequestAsync(LogChallengeEventRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LogChallengeEventRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<EventsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous LogEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<EventsResponse> LogEventRequestAsync(LogEventRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LogEventRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<EventsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous LogEventRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<EventsResponse> LogEventRequestAsync(string requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LogEventRequest, requestData);
            return JsonConvert.DeserializeObject<EventsResponse>(res.ResponseJson);
        }
        #endregion
    }
}
