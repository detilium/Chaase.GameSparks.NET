using GameSparks.NET.Services.Authentication.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services.Authentication.Requests
{
    public class DeviceAuthenticationRequest : GameSparksBaseAuthenticationRequest
    {
        [JsonProperty("@class")]
        private string ClassStr { get { return ".DeviceAuthenticationRequest"; } }
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
        [JsonProperty("deviceModel")]
        public string DeviceModel { get; set; }
        [JsonProperty("displayName")]
        public string DeviceName { get; set; }
        [JsonProperty("deviceOS")]
        public string DeviceOS { get; set; }
        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("operatinSystem")]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Initialize a new DeviceAuthenticationRequest
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="deviceModel"></param>
        /// <param name="deviceName"></param>
        /// <param name="deviceOS"></param>
        /// <param name="deviceType"></param>
        /// <param name="displayName"></param>
        /// <param name="operatingSystem"></param>
        /// <param name="requestId"></param>
        /// <param name="segments"></param>
        public DeviceAuthenticationRequest(string deviceId, string deviceModel, string deviceName, string deviceOS, string deviceType, string displayName, string operatingSystem, string requestId = "", dynamic segments = null)
        {
            DeviceId = deviceId;
            DeviceModel = deviceModel;
            DeviceName = deviceName;
            DeviceOS = deviceOS;
            DeviceType = deviceType;
            DisplayName = displayName;
            OperatingSystem = operatingSystem;
            RequestId = requestId;
            Segments = segments;
        }
    }
}
