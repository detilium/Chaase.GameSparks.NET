using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Misc.Requests;
using GameSparks.NET.Services.Misc.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksMiscService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new GetDownloadableRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetDownloadableResponse GetDownloadableRequest(GetDownloadableRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetDownloadableResponse>(Requestor.PostString(Urls.GetDownloadableRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetPropertyRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetPropertyResponse GetPropertyRequest(GetPropertyRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetPropertyResponse>(Requestor.PostString(Urls.GetPropertyRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetPropertySetRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetPropertySetResponse GetPropertySetRequest(GetPropertySetRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetPropertySetResponse>(Requestor.PostString(Urls.GetPropertySetRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetUploadUrlRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetUploadUrlResponse GetUploadUrlRequest(GetUploadUrlRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetUploadUrlResponse>(Requestor.PostString(Urls.GetUploadUrlRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GetUploadedRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GetUploadedResponse GetUploadedRequest(GetUploadedRequest requestData)
        {
            return JsonConvert.DeserializeObject<GetUploadedResponse>(Requestor.PostString(Urls.GetUploadedRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new PushRegistrationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public PushRegistrationResponse PushRegistrationRequest(PushRegistrationRequest requestData)
        {
            return JsonConvert.DeserializeObject<PushRegistrationResponse>(Requestor.PostString(Urls.PushRegistrationRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SocialStatusRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public SocialStatusResponse SocialStatusRequest(SocialStatusRequest requestData)
        {
            return JsonConvert.DeserializeObject<SocialStatusResponse>(Requestor.PostString(Urls.SocialStatusRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous GetDownloadableRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetDownloadableResponse> GetDownloadableRequestAsync(GetDownloadableRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetDownloadableRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetDownloadableResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetPropertyRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetPropertyResponse> GetPropertyRequestAsync(GetPropertyRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetPropertyRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetPropertyResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetPropertySetRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetPropertySetResponse> GetPropertySetRequestAsync(GetPropertySetRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetPropertySetRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetPropertySetResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetUploadUrlRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetUploadUrlResponse> GetUploadUrlRequestAsync(GetUploadUrlRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetUploadUrlRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetUploadUrlResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GetUploadedRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GetUploadedResponse> GetUploadedRequestAsync(GetUploadedRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GetUploadedRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GetUploadedResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous PushRegistrationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<PushRegistrationResponse> GPushRegistrationRequestAsync(PushRegistrationRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.PushRegistrationRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<PushRegistrationResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous SocialStatusRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<SocialStatusResponse> SocialStatusRequestAsync(SocialStatusRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SocialStatusRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<SocialStatusResponse>(res.ResponseJson);
        }
        #endregion
    }
}
