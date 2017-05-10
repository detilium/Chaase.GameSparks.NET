using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Admin.Requests;
using GameSparks.NET.Services.Admin.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksAdminService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new BatchAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public BatchAdminResponse BatchAdminRequest(BatchAdminRequest requestData)
        {
            return JsonConvert.DeserializeObject<BatchAdminResponse>(Requestor.PostString(Urls.BatchAdminRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new CancelBulkJobAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public CancelBulkJobAdminResponse CancelBulkJobAdminRequest(CancelBulkJobAdminRequest requestData)
        {
            return JsonConvert.DeserializeObject<CancelBulkJobAdminResponse>(Requestor.PostString(Urls.CancelBulkJobAdminRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListBulkJobsAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListBulkJobsAdminResponse ListBulkJobsAdminRequest(ListBulkJobsAdminRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListBulkJobsAdminResponse>(Requestor.PostString(Urls.BatchAdminRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new RevokePurchaseGoods
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public RevokePurchaseGoodsResponse RevokePurchaseGoods(RevokePurchaseGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<RevokePurchaseGoodsResponse>(Requestor.PostString(Urls.BatchAdminRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ScheduledBulkJobAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ScheduledBulkJobAdminResponse ScheduledBulkJobAdminRequest(ScheduleBulkJobAdminRequest requestData)
        {
            return JsonConvert.DeserializeObject<ScheduledBulkJobAdminResponse>(Requestor.PostString(Urls.BatchAdminRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Being a new asynchronous BatchAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<BatchAdminResponse> BatchAdminRequestAsync(BatchAdminRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.BatchAdminRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<BatchAdminResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Being a new asynchronous CancelBulkJobAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<CancelBulkJobAdminResponse> CancelBulkJobAdminRequestAsync(CancelBulkJobAdminRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.CancelBulkJobAdminRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<CancelBulkJobAdminResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Being a new asynchronous ListBulkJobsAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListBulkJobsAdminResponse> ListBulkJobsAdminRequestAsync(ListBulkJobsAdminRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListBulkJobsAdminRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListBulkJobsAdminResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Being a new asynchronous RevokePurchaseGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<RevokePurchaseGoodsResponse> RevokePurchaseGoodsRequestAsync(RevokePurchaseGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.RevokePurchaseGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<RevokePurchaseGoodsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Being a new asynchronous ScheduleBulkJobAdminRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ScheduledBulkJobAdminResponse> ScheduleBulkJobAdminRequestAsync(ScheduleBulkJobAdminRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ScheduleBulkJobAdminRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ScheduledBulkJobAdminResponse>(res.ResponseJson);
        }
        #endregion 
    }
}
