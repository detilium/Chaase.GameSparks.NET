using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksTransaction
    {
        [JsonProperty("items")]
        public List<GameSparksTransactionItem> Items { get; set; }
        [JsonProperty("originalRequestId")]
        public string OriginalRequestId { get; set; }
        [JsonProperty("playerId")]
        public string PlayerId { get; set; }
        [JsonProperty("reason")]
        public string Reason { get; set; }
        [JsonProperty("revokeDate")]
        public DateTime RevokeDate { get; set; }
        [JsonProperty("script")]
        public string Script { get; set; }
        [JsonProperty("scriptType")]
        public string ScriptType { get; set; }
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
        [JsonProperty("when")]
        public DateTime When { get; set; }
    }
}
