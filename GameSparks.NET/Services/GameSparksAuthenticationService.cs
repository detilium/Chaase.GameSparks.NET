using GameSparks.NET.Infrastructure;
using GameSparks.NET.Infrastructure.Exceptions;
using GameSparks.NET.Services.Authentication.Requests;
using GameSparks.NET.Services.Authentication.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Services
{
    public class GameSparksAuthenticationService
    {
        #region Synchronous
        /// <summary>
        /// Begin a new AmazonConnectRequest 
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public GameSparksAuthenticationResponse AmazonConnectRequest(AmazonConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.AmazonConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new AuthenticationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public GameSparksAuthenticationResponse AuthenticationRequest(AuthenticationRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.AuthenticationRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new DeviceAuthenticationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public GameSparksAuthenticationResponse DeviceAuthenticationRequest(DeviceAuthenticationRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.DeviceAuthenticationRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new FacebookConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse FacebookConnectRequest(FacebookConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.FacebookConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GameCenterConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse GameCenterConnectRequest(GameCenterConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.GameCenterConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GooglePlayConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse GooglePlayConnectRequest(GooglePlayConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.GooglePlayConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new GooglePlusConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse GooglePlusConnectRequest(GooglePlusConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.GooglePlusConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new KongregateConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse KongregateConnectRequest(KongregateConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.KongregateConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new NXConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse NXConnectRequest(NXConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.NXConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new PSNConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse PSNConnectRequest(PSNConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.PSNConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new QQConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse QQConnectRequest(QQConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.QQConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new RegistrationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse RegistrationRequest(RegistrationRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.RegistrationRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new SteamConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse SteamConnectRequest(SteamConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.SteamConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new TwitchConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse TwitchConnectRequest(TwitchConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.TwitchConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new TwitterConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse TwitterConnectRequest(TwitterConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.TwitterConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new ViberConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse ViberConnectRequest(ViberConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.ViberConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new WeChatConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse WeChatConnectRequest(WeChatConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.WeChatConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new XBOXLiveConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse XBOXLiveConnectRequest(XBOXLiveConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.XBOXLiveConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }

        /// <summary>
        /// Begin a new XboxOneConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns></returns>
        public GameSparksAuthenticationResponse XboxOneConnectRequest(XboxOneConnectRequest requestData)
        {
            return DeserializeResponse(Requestor.PostString(Urls.XboxOneConnectRequest, SerializeRequest(requestData)).ResponseJson);
        }
        #endregion

        #region Asynchronous
        /// <summary>
        /// Begin a new asynchronous AmazonConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> AmazonConnectRequestAsync(AmazonConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AmazonConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous AuthenticationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> AuthenticationRequestAsync(AuthenticationRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.AuthenticationRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous DeviceAuthenticationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> DeviceAuthenticationRequestAsync(DeviceAuthenticationRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.DeviceAuthenticationRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous FacebookConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> FacebookConnectRequestAsync(FacebookConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.FacebookConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GameCenterConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> GameCenterConnectRequestAsync(GameCenterConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GameCenterConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GooglePlayConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> GooglePlayConnectRequestAsync(GooglePlayConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GooglePlayConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous GooglePlusConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> GooglePlusConnectRequestAsync(GooglePlusConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.GooglePlusConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous KongregateConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> KongregateConnectRequestAsync(KongregateConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.KongregateConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous NXConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> NXConnectRequestAsync(NXConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.NXConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous PSNConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> PSNConnectRequestAsync(PSNConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.PSNConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous QQConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> QQConnectRequestAsync(QQConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.QQConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous RegistrationRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> RegistrationRequestAsync(RegistrationRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.RegistrationRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous SteamConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> SteamConnectRequestAsync(SteamConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.SteamConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous TwitchConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> TwitchConnectRequestAsync(TwitchConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.TwitchConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous TwitterConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> TwitterConnectRequestAsync(TwitterConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.TwitterConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous ViberConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> ViberConnectRequestAsync(ViberConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.ViberConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous WeChatConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> WeChatConnectRequestAsync(WeChatConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.WeChatConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous XBOXLiveConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> XBOXLiveConnectRequestAsync(XBOXLiveConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.XBOXLiveConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }

        /// <summary>
        /// Begin a new asynchronous XboxOneConnectRequest
        /// </summary>
        /// <param name="requestData"></param>
        /// <returns>GameSparksAuthentication</returns>
        public async Task<GameSparksAuthenticationResponse> XboxOneConnectRequestAsync(XboxOneConnectRequest requestData)
        {
            var res = await Requestor.PostStringAsync(Urls.XboxOneConnectRequest, SerializeRequest(requestData));
            return DeserializeResponse(res.ResponseJson);
        }
        #endregion

        #region Helpers

        private string SerializeRequest(dynamic requestData)
        {
            return JsonConvert.SerializeObject(requestData, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        private GameSparksAuthenticationResponse DeserializeResponse(string responseJson)
        {
            return JsonConvert.DeserializeObject<GameSparksAuthenticationResponse>(responseJson);
        }

        #endregion 
    }
}
