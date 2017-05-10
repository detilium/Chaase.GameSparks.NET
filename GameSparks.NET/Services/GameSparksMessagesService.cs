using GameSparks.NET.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksMessagesService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new MessagesRequest
        /// </summary>
        /// <returns></returns>
        public dynamic MessagesRequest()
        {
            return JsonConvert.DeserializeObject<dynamic>(Requestor.PostString(Urls.MessagesRequest, "").ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous MessageRequest
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> MessagesRequestAsync()
        {
            var res = await Requestor.PostStringAsync(Urls.MessagesRequest, "");
            return JsonConvert.DeserializeObject<dynamic>(res.ResponseJson);
        }
        #endregion
    }
}
