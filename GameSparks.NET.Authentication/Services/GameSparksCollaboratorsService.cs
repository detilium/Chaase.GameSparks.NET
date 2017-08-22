using GameSparks.NET.Authentication.Entitites;
using GameSparks.NET.Authentication.Infrastructure;
using GameSparks.NET.Authentication.Infrastructure.Helpers;
using GameSparks.NET.Authentication.Services.Collaborators.Requests;
using GameSparks.NET.Authentication.Services.Collaborators.Responses;
using GameSparks.NET.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Authentication.Services
{
    public class GameSparksCollaboratorsService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new synchronous GetCollaborators request
        /// </summary>
        /// <returns></returns>
        public GetCollaboratorsResponse GetCollaborators()
        {
            return JsonConvert.DeserializeObject<GetCollaboratorsResponse>(Requestor.GetString(Urls.Collborators).ResponseJson);
        }

        /// <summary>
        /// Begin a new synchronous CreateCollaborator request
        /// </summary>
        /// <returns></returns>
        public GameSparksCollaborator CreateCollaborator(PostCollaboratorsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(Requestor.PostString(Urls.Collborators, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new synchronous DeleteCollaborator request
        /// </summary>
        /// <returns></returns>
        public DeleteCollaboratorsResponse DeleteCollaborator(string email)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, email);
            return JsonConvert.DeserializeObject<DeleteCollaboratorsResponse>(Requestor.DeleteString(url).ResponseJson);
        }

        /// <summary>
        /// Begin a new synchronous GetCollaborator request
        /// </summary>
        /// <returns></returns>
        public GameSparksCollaborator GetCollaborator(string email)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, email);
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(Requestor.GetString(url).ResponseJson);
        }

        /// <summary>
        /// Begin a new synchronous UpdateCollaborator request
        /// </summary>
        /// <returns></returns>
        public GameSparksCollaborator UpdateCollaborator(PostCollaboratorsRequest requestData)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, requestData.Email);
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(Requestor.PutString(url, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous GetCollaborator request
        /// </summary>
        /// <returns></returns>
        public async Task<GetCollaboratorsResponse> GetCollaboratorsAsync()
        {
            var res = await Requestor.GetStringAsync(Urls.Collborators);
            return JsonConvert.DeserializeObject<GetCollaboratorsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous CreateCollaborator request
        /// </summary>
        /// <returns></returns>
        public async Task<GameSparksCollaborator> CreateCollaboratorAsync(PostCollaboratorsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.Collborators, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous DeleteCollaborator request
        /// </summary>
        /// <returns></returns>
        public async Task<DeleteCollaboratorsResponse> DeleteCollaboratorAsync(string email)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, email);
            var res = await Requestor.DeleteStringAsync(url);
            return JsonConvert.DeserializeObject<DeleteCollaboratorsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetCollaborator request
        /// </summary>
        /// <returns></returns>
        public async Task<GameSparksCollaborator> GetCollaboratorAsync(string email)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, email);
            var res = await Requestor.GetStringAsync(url);
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous UpdateCollaborator request
        /// </summary>
        /// <returns></returns>
        public async Task<GameSparksCollaborator> UpdateCollaboratorAsync(PostCollaboratorsRequest requestData)
        {
            var url = string.Format(Urls.CollboratorsWithEmail, requestData.Email);
            var res = await Requestor.PutStringAsync(url, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksCollaborator>(res.ResponseJson);
        }
        #endregion
    }
}
