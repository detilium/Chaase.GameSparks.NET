using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Authentication.Infrastructure.Helpers
{
    internal static class JsonHelper
    {
        internal static string SerializeData(dynamic requestData)
        {
            return JsonConvert.SerializeObject(requestData, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
