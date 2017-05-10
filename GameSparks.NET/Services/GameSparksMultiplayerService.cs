using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Multiplayer.Requests;
using GameSparks.NET.Services.Multiplayer.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksMultiplayerService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AcceptChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public AcceptChallengeResponse AcceptChallengeRequest(AcceptChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<AcceptChallengeResponse>(Requestor.PostString(Urls.AcceptChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ChatOnChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ChatOnChallengeResponse ChatOnChallengeRequest(ChatOnChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<ChatOnChallengeResponse>(Requestor.PostString(Urls.ChatOnChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new CreateChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public CreateChallengeResponse CreateChallengeRequest(CreateChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<CreateChallengeResponse>(Requestor.PostString(Urls.CreateChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new DeclineChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public DeclineChallengeResponse DeclineChallengeRequest(DeclineChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<DeclineChallengeResponse>(Requestor.PostString(Urls.DeclineChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new FindChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public FindChallengeResponse FindChallengeRequest(FindChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<FindChallengeResponse>(Requestor.PostString(Urls.FindChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new FindMatchRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public FindMatchResponse FindMatchRequest(FindMatchRequest requestData)
        {
            return JsonConvert.DeserializeObject<FindMatchResponse>(Requestor.PostString(Urls.FindMatchRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new FindPendingMatchesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public FindPendingMatchesResponse FindPendingMatchesRequest(FindPendingMatchesRequest requestData)
        {
            return JsonConvert.DeserializeObject<FindPendingMatchesResponse>(Requestor.PostString(Urls.FindPendingMatchesRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetChallengeResponse GetChallengeRequest(GetChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetChallengeResponse>(Requestor.PostString(Urls.GetChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new JoinChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public JoinChallengeResponse JoinChallengeRequest(JoinChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<JoinChallengeResponse>(Requestor.PostString(Urls.JoinChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new JoinPendingMatchRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public JoinPendingMatchResponse JoinPendingMatchRequest(JoinPendingMatchRequest requestData)
        {
            return JsonConvert.DeserializeObject<JoinPendingMatchResponse>(Requestor.PostString(Urls.JoinPendingMatchRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListChallengeResponse ListChallengeRequest(ListChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListChallengeResponse>(Requestor.PostString(Urls.ListChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListChallengeTypeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListChallengeTypeResponse ListChallengeTypeRequest(ListChallengeTypeRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListChallengeTypeResponse>(Requestor.PostString(Urls.ListChallengeTypeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new MatchDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public MatchDetailsResponse MatchDetailsRequest(MatchDetailsRequest requestData)
        {
            return JsonConvert.DeserializeObject<MatchDetailsResponse>(Requestor.PostString(Urls.MatchDetailsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new MatchmakingRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBaseMultiplayerResponse MatchmakingRequest(MatchmakingRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBaseMultiplayerResponse>(Requestor.PostString(Urls.MatchmakingRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new WithdrawChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public WithdrawChallengeResponse WithdrawChallengeRequest(WithdrawChallengeRequest requestData)
        {
            return JsonConvert.DeserializeObject<WithdrawChallengeResponse>(Requestor.PostString(Urls.WithdrawChallengeRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous AcceptChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<AcceptChallengeResponse> AcceptChallengeRequestAsync(AcceptChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AcceptChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<AcceptChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ChatOnChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ChatOnChallengeResponse> ChatOnChallengeRequestAsync(ChatOnChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ChatOnChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ChatOnChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous CreateChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<CreateChallengeResponse> CreateChallengeRequestAsync(CreateChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.CreateChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<CreateChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous DeclineChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<DeclineChallengeResponse> DeclineChallengeRequestAsync(DeclineChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.DeclineChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<DeclineChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous FindChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<FindChallengeResponse> FindChallengeRequestAsync(FindChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.FindChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<FindChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous FindMatchRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<FindMatchResponse> FindMatchRequestAsync(FindMatchRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.FindMatchRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<FindMatchResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous FindPendingMatchesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<FindPendingMatchesResponse> FindPendingMatchesRequestAsync(FindPendingMatchesRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.FindPendingMatchesRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<FindPendingMatchesResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetChallengeResponse> GetChallengeRequestAsync(GetChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous JoinChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<JoinChallengeResponse> JoinChallengeRequestAsync(JoinChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.JoinChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<JoinChallengeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous JoinPendingMatchRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<JoinPendingMatchResponse> JoinPendingMatchRequestAsync(JoinPendingMatchRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.JoinPendingMatchRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<JoinPendingMatchResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ListChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListChallengeResponse> ListChallengeRequestAsync(ListChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListChallengeResponse>(res.ResponseJson);
        }
        /// <summary>
        /// Begin a new asynchronous ListChallengeTypeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>

        public async Task<ListChallengeTypeResponse> ListChallengeTypeRequestAsync(ListChallengeTypeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListChallengeTypeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListChallengeTypeResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous MatchDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<MatchDetailsResponse> MatchDetailsRequestAsync(MatchDetailsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.MatchDetailsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<MatchDetailsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous MatchmakingRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBaseMultiplayerResponse> MatchmakingRequestAsync(MatchmakingRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.MatchmakingRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBaseMultiplayerResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous WithdrawChallengeRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<WithdrawChallengeResponse> WithdrawChallengeRequestAsync(WithdrawChallengeRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.WithdrawChallengeRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<WithdrawChallengeResponse>(res.ResponseJson);
        }
        #endregion
    }
}
