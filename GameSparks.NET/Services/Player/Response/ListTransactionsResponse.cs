using GameSparks.NET.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Player.Response
{
    public class ListTransactionsResponse : GameSparksBasePlayerResponse
    {
        [JsonProperty("transactionList")]
        public List<GameSparksTransaction> TransactionList { get; set; }
    }
}
