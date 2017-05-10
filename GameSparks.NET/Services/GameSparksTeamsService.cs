using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Teams.Requests;
using GameSparks.NET.Services.Teams.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksTeamsService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new CreateTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public CreateTeamResponse CreateTeamRequest(CreateTeamRequest requestData)
        {
            return JsonConvert.DeserializeObject<CreateTeamResponse>(Requestor.PostString(Urls.CreateTeamRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new DropTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBaseTeamsResponse DropTeamRequest(DropTeamRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBaseTeamsResponse>(Requestor.PostString(Urls.DropTeamRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetMyTeamsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetMyTeamsResponse GetMyTeamsRequest(GetMyTeamsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetMyTeamsResponse>(Requestor.PostString(Urls.GetMyTeamsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetTeamResponse GetTeamRequest(GetTeamRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetTeamResponse>(Requestor.PostString(Urls.GetTeamRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new JoinTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public JoinTeamResponse JoinTeamRequest(JoinTeamRequest requestData)
        {
            return JsonConvert.DeserializeObject<JoinTeamResponse>(Requestor.PostString(Urls.JoinTeamRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new LeaveTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public LeaveTeamResponse LeaveTeamRequest(LeaveTeamRequest requestData)
        {
            return JsonConvert.DeserializeObject<LeaveTeamResponse>(Requestor.PostString(Urls.LeaveTeamRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListTeamChatRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListTeamChatResponse ListTeamChatRequest(ListTeamChatRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListTeamChatResponse>(Requestor.PostString(Urls.ListTeamChatRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListTeamsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListTeamsResponse ListTeamsRequest(ListTeamsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListTeamsResponse>(Requestor.PostString(Urls.ListTeamsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SendTeamChatMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBaseTeamsResponse SendTeamChatMessageRequest(SendTeamChatMessageRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBaseTeamsResponse>(Requestor.PostString(Urls.SendTeamChatMessageRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous CreateTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<CreateTeamResponse> CreateTeamRequestAsync(CreateTeamRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.CreateTeamRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<CreateTeamResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous DropTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBaseTeamsResponse> DropTeamRequestAsync(DropTeamRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.DropTeamRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBaseTeamsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetMyTeamsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetMyTeamsResponse> GetMyTeamsRequestAsync(GetMyTeamsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetMyTeamsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetMyTeamsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetTeamResponse> GetTeamRequestAsync(GetTeamRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetTeamRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetTeamResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous JoinTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<JoinTeamResponse> JoinTeamRequestAsync(JoinTeamRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.JoinTeamRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<JoinTeamResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous LeaveTeamRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<LeaveTeamResponse> LeaveTeamRequestAsync(LeaveTeamRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.LeaveTeamRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<LeaveTeamResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ListTeamChatRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListTeamChatResponse> ListTeamChatRequestAsync(ListTeamChatRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListTeamChatRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListTeamChatResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ListTeamsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListTeamsResponse> ListTeamsRequestAsync(ListTeamsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListTeamsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListTeamsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous SendTeamChatMessageRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksBaseTeamsResponse> SendTeamChatMessageRequestAsync(SendTeamChatMessageRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SendTeamChatMessageRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksBaseTeamsResponse>(res.ResponseJson);
        }
        #endregion
    }
}
