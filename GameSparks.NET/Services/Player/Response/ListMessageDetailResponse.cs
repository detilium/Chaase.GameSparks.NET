using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class ListMessageDetailResponse : GameSparksBasePlayerResponse
    {
        [JsonProperty("messageList")]
        public List<GameSparksMessage> MessageList { get; set; }
    }
}
