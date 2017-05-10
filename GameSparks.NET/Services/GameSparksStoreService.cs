using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Helpers;
using GameSparks.NET.Services.Store.Requests;
using GameSparks.NET.Services.Store.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksStoreService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AmazonBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse AmazonBuyGoodsRequest(AmazonBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.AmazonBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new BuyVirtualGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse BuyVirtualGoodsRequest(BuyVirtualGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.BuyVirtualGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ConsumeVirtualGoodRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksBaseStoreResponse ConsumeVirtualGoodRequest(ConsumeVirtualGoodRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksBaseStoreResponse>(Requestor.PostString(Urls.ConsumeVirtualGoodRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GooglePlayBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse GooglePlayBuyGoodsRequest(GooglePlayBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.GooglePlayBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new IOSBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse IOSBuyGoodsRequest(IOSBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.IOSBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ListVirtualGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public ListVirtualGoodsResponse ListVirtualGoodsRequest(ListVirtualGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<ListVirtualGoodsResponse>(Requestor.PostString(Urls.ListVirtualGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new PsnBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse PsnBuyGoodsRequest(PsnBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.PsnBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SteamBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse SteamBuyGoodsRequest(SteamBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.SteamBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new WindowsBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksStoreExternalResponse WindowsBuyGoodsRequest(WindowsBuyGoodsRequest requestData)
        {
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(Requestor.PostString(Urls.WindowsBuyGoodsRequest, JsonHelper.SerializeData(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous AmazonBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> AmazonBuyGoodsRequestAsync(AmazonBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AmazonBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous BuyVirtualGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> BuyVirtualGoodsRequestAsync(BuyVirtualGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.BuyVirtualGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ConsumeVirtualGoodRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> ConsumeVirtualGoodRequestAsync(ConsumeVirtualGoodRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ConsumeVirtualGoodRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GooglePlayBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> GooglePlayBuyGoodsRequestAsync(GooglePlayBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GooglePlayBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous IOSBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> IOSBuyGoodsRequestAsync(IOSBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.IOSBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ListVirtualGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<ListVirtualGoodsResponse> ListVirtualGoodsRequestAsync(ListVirtualGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ListVirtualGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<ListVirtualGoodsResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous PsnBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> PsnBuyGoodsRequestAsync(PsnBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.PsnBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous SteamBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> SteamBuyGoodsRequestAsync(SteamBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SteamBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous WindowsBuyGoodsRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public async Task<GameSparksStoreExternalResponse> WindowsBuyGoodsRequestAsync(WindowsBuyGoodsRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.WindowsBuyGoodsRequest, JsonHelper.SerializeData(requestData));
            return JsonConvert.DeserializeObject<GameSparksStoreExternalResponse>(res.ResponseJson);
        }
        #endregion
    }
}
