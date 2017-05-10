using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Analytics.Requests;
using GameSparks.NET.Services.Analytics.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksAnalyticsService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AnalyticsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public AnalyticsResponse AnalyticsRequest(AnalyticsRequest requestData)
        {
            return JsonConvert.DeserializeObject<AnalyticsResponse>(Requestor.PostString(Urls.AnalyticsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new EndSessionRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public EndSessionResponse EndSessionRequest(EndSessionRequest requestData)
        {
            return JsonConvert.DeserializeObject<EndSessionResponse>(Requestor.PostString(Urls.EndSessionRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous AnalyticsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<AnalyticsResponse> AnalyticsRequestAsync(AnalyticsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AnalyticsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<AnalyticsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous EndSessionRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<EndSessionResponse> EndSessionRequestAsync(EndSessionRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AnalyticsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<EndSessionResponse>(res.ResponseJson);
        }
        #endregion
    }
}
