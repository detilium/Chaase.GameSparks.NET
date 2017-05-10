using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksPlayerFriend
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("profilePic")]
        public string ProfilePic { get; set; }
    }
}
