using GameSparks.NET.Entities;
using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Leaderboards.Requests;
using GameSparks.NET.Services.Leaderboards.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksLeaderboardsService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AroundMeLeaderboardRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardDataResponse AroundMeLeaderboardRequest(AroundMeLeaderboardRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(Requestor.PostString(Urls.AroundMeLeaderboardRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetLeaderboardEntriesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardResponse GetLeaderboardEntriesRequest(GetLeaderboardEntriesRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardResponse>(Requestor.PostString(Urls.GetLeaderboardEntriesRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LeaderboardDataRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardDataResponse LeaderboardDataRequest(LeaderboardDataRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(Requestor.PostString(Urls.LeaderboardDataRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LeaderboardDataRequest and deserialize data objects into type T, where T extends GameSparksLeaderboardUserData
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardCustomDataResponse<T> LeaderboardDataRequest<T>(LeaderboardDataRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardCustomDataResponse<T>>(Requestor.PostString(Urls.LeaderboardDataRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LeaderboardsEntriesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardResponse LeaderboardsEntriesRequest(LeaderboardsEntriesRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardResponse>(Requestor.PostString(Urls.LeaderboardsEntriesRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListLeaderboardsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListLeaderboardsResponse ListLeaderboardsRequest(ListLeaderboardsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListLeaderboardsResponse>(Requestor.PostString(Urls.ListLeaderboardsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SocialLeaderboardDataRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksLeaderboardDataResponse SocialLeaderboardDataRequest(SocialLeaderboardDataRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(Requestor.PostString(Urls.SocialLeaderboardDataRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous AroundMeLeaderboardRequestAsync
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksLeaderboardDataResponse> AroundMeLeaderboardRequestAsync(AroundMeLeaderboardRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AroundMeLeaderboardRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetLeaderboardEntriesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksLeaderboardResponse> GetLeaderboardEntriesRequestAsync(GetLeaderboardEntriesRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetLeaderboardEntriesRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksLeaderboardResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous LeaderboardDataRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksLeaderboardDataResponse> LeaderboardDataRequestAsync(LeaderboardDataRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LeaderboardDataRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous LeaderboardsEntriesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksLeaderboardResponse> LeaderboardsEntriesRequestAsync(LeaderboardsEntriesRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LeaderboardsEntriesRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksLeaderboardResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ListLeaderboardsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListLeaderboardsResponse> ListLeaderboardsRequestAsync(ListLeaderboardsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListLeaderboardsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListLeaderboardsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous SocialLeaderboardDataRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksLeaderboardDataResponse> SocialLeaderboardDataRequestAsync(SocialLeaderboardDataRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SocialLeaderboardDataRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksLeaderboardDataResponse>(res.ResponseJson);
        }
        #endregion
    }
}
