using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Player.Requests;
using GameSparks.NET.Services.Player.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksPlayerService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AccountDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public AccountDetailsResponse AccountDetailsRequest(AccountDetailsRequest requestData)
        {
            return JsonConvert.DeserializeObject<AccountDetailsResponse>(Requestor.PostString(Urls.AccountDetailsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ChangeUserDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBasePlayerResponse ChangeUserDetailsRequest(ChangeUserDetailsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(Requestor.PostString(Urls.ChangeUserDetailsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new DismissMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBasePlayerResponse DismissMessageRequest(DismissMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(Requestor.PostString(Urls.DismissMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new DismissMultipleMessagesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public DismissMultipleMessagesResponse DismissMultipleMessagesRequest(DismissMultipleMessagesRequest requestData)
        {
            return JsonConvert.DeserializeObject<DismissMultipleMessagesResponse>(Requestor.PostString(Urls.DismissMultipleMessagesRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetMessageResponse GetMessageRequest(GetMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetMessageResponse>(Requestor.PostString(Urls.GetMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListAchievementsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListAchievementsResponse ListAchievementsRequest(ListAchievementsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListAchievementsResponse>(Requestor.PostString(Urls.ListAchievementsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListGameFriendsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListGameFriendsResponse ListGameFriendsRequest(ListGameFriendsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListGameFriendsResponse>(Requestor.PostString(Urls.ListGameFriendsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListInviteFriendsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListInviteFriendsResponse ListInviteFriendsRequest(ListInviteFriendsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListInviteFriendsResponse>(Requestor.PostString(Urls.ListInviteFriendsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListMessageDetailRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListMessageDetailResponse ListMessageDetailRequest(ListMessageDetailRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListMessageDetailResponse>(Requestor.PostString(Urls.ListMessageDetailRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListMessageResponse ListMessageRequest(ListMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListMessageResponse>(Requestor.PostString(Urls.ListMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListMessageSummaryRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListMessageSummaryResponse ListMessageSummaryRequest(ListMessageSummaryRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListMessageSummaryResponse>(Requestor.PostString(Urls.ListMessageSummaryRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListTransactionsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListTransactionsResponse ListTransactionsRequest(ListTransactionsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListTransactionsResponse>(Requestor.PostString(Urls.ListTransactionsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SendFriendMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBasePlayerResponse SendFriendMessageRequest(SendFriendMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(Requestor.PostString(Urls.SendFriendMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SocialDisconnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBasePlayerResponse SocialDisconnectRequest(SocialDisconnectRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(Requestor.PostString(Urls.SocialDisconnectRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new UpdateMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBasePlayerResponse UpdateMessageRequest(UpdateMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(Requestor.PostString(Urls.UpdateMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchornous AccountDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<AccountDetailsResponse> AccountDetailsRequestAsync(AccountDetailsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AccountDetailsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<AccountDetailsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ChangeUserDetailsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBasePlayerResponse> ChangeUserDetailsRequestAsync(ChangeUserDetailsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ChangeUserDetailsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous DismissMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBasePlayerResponse> DismissMessageRequestAsync(DismissMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.DismissMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous DismissMultipleMessagesRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<DismissMultipleMessagesResponse> DismissMultipleMessagesRequestAsync(DismissMultipleMessagesRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.DismissMultipleMessagesRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<DismissMultipleMessagesResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous GetMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetMessageResponse> GetMessageRequestAsync(GetMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetMessageResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListAchievementsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListAchievementsResponse> ListAchievementsRequestAsync(ListAchievementsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListAchievementsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListAchievementsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListGameFriendsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListGameFriendsResponse> ListGameFriendsRequestAsync(ListGameFriendsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListGameFriendsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListGameFriendsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListInviteFriendsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListInviteFriendsResponse> ListInviteFriendsRequestAsync(ListInviteFriendsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListInviteFriendsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListInviteFriendsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListMessageDetailRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListMessageDetailResponse> ListMessageDetailRequestAsync(ListMessageDetailRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListMessageDetailRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListMessageDetailResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListMessageResponse> ListMessageRequestAsync(ListMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListMessageResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListMessageSummaryRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListMessageSummaryResponse> ListMessageSummaryRequestAsync(ListMessageSummaryRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListMessageSummaryRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListMessageSummaryResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous ListTransactionsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListTransactionsResponse> ListTransactionsRequestAsync(ListTransactionsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListTransactionsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListTransactionsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous SendFriendMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBasePlayerResponse> SendFriendMessageRequestAsync(SendFriendMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SendFriendMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous SocialDisconnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBasePlayerResponse> SocialDisconnectRequestAsync(SocialDisconnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SocialDisconnectRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchornous UpdateMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBasePlayerResponse> UpdateMessageRequestAsync(UpdateMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.UpdateMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBasePlayerResponse>(res.ResponseJson);
        }
        #endregion
    }
}
