using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Admin.Responses
{
    public class RevokePurchaseGoodsResponse
    {
        [JsonProperty("revokedGoods")]
        public dynamic RevokedGoods { get; set; }
    }
}
