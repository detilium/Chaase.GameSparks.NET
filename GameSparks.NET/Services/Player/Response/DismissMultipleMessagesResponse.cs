using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class DismissMultipleMessagesResponse : GameSparksBasePlayerResponse
    {
        [JsonProperty("failedDismissals")]
        public List<string> FailedDismissals { get; set; }
        [JsonProperty("messageDismissed")]
        public int MessagesDismissed { get; set; }
    }
}
