using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GameSparks.NET.Infrastructure.Settings
{
    public static class GameSparksSettings
    {
        public static string GameSparksNetVersion { get; private set; }

        private static string _apiKey;
        private static string _credentials;
        private static string _secret;
        private static bool _isLive;

        /// <summary>
        /// Creates a new instance of GameSparks settings. These settings are used to communicate with the GameSparks API, 
        /// and should be relevant for your specific GameSparks instance. You can find these settings in your GameSparks Portal.
        /// </summary>
        static GameSparksSettings()
        {
            GameSparksNetVersion = new AssemblyName(typeof(Requestor).GetTypeInfo().Assembly.FullName).Version.ToString(3);
        }

        internal static string GetApiKey()
        {
            return _apiKey;
        }

        /// <summary>
        /// Set the GameSparks settings
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="credentials"></param>
        /// <param name="secret"></param>
        /// <param name="isLive"></param>
        public static void Set(string apiKey, string credentials, string secret, bool isLive = false)
        {
            _apiKey = apiKey;
            _credentials = credentials;
            _secret = secret;
            _isLive = isLive;
        }

        /// <summary>
        /// Set the GameSparks API key
        /// </summary>
        /// <param name="apiKey"></param>
        public static void SetApiKey(string apiKey)
        {
            _apiKey = apiKey;
        }

        internal static string GetCredentials()
        {
            return _credentials;
        }

        /// <summary>
        /// Set the GameSparks credentials
        /// </summary>
        /// <param name="credentials"></param>
        public static void SetCredentials(string credentials)
        {
            _credentials = credentials;
        }

        internal static string GetSecret()
        {
            return _secret;
        }

        /// <summary>
        /// Set the GameSparks API secret
        /// </summary>
        /// <param name="secret"></param>
        public static void SetSecret(string secret)
        {
            _secret = secret;
        }

        internal static bool GetIsLive()
        {
            return _isLive;
        }

        /// <summary>
        /// Set to "true" if the environment you are aiming for is "live", otherwise set to "false" if environment is "preview"
        /// </summary>
        /// <param name="isLive"></param>
        public static void SetIsLive(bool isLive)
        {
            _isLive = isLive;
        }
    }
}
