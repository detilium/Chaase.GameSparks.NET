﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksBaseRequest
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}
