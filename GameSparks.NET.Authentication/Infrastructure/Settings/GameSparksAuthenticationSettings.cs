using GameSparks.NET.Authentication.Infrastructure.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace GameSparks.NET.Authentication.Infrastructure.Settings
{
    public static class GameSparksAuthenticationSettings
    {
        private static string _apiKey;
        private static string _userName;
        private static string _password;


        /// <summary>
        /// Set the GameSparks Authentication settings
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public static void Set(string apiKey, string userName, string password)
        {
            _apiKey = apiKey;
            _userName = userName;
            _password = password;
        }

        internal static string GetApiKey()
        {
            return _apiKey;
        }

        /// <summary>
        /// Set the GameSparks API key
        /// </summary>
        /// <param name="apiKey"></param>
        public static void SetApiKey(string apiKey)
        {
            _apiKey = apiKey;
        }

        internal static string GetUserName()
        {
            return _userName;
        }

        /// <summary>
        /// Set the GameSparks Authentication user username
        /// </summary>
        /// <param name="userName"></param>
        public static void SetUserName(string userName)
        {
            _userName = userName;
        }

        internal static string GetPassword()
        {
            return _password;
        }

        /// <summary>
        /// Set the GameSparks Authentication user password
        /// </summary>
        /// <param name="password"></param>
        public static void SetPassword(string password)
        {
            _password = password;
        }

        internal static string GetBasicAuthenticationHeaderValue()
        {
            if (string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
                throw new GameSparksSettingsException("GameSparks Authentication settings has not been correctly configured. Remember to provide a username, a password, and the GameSparks REST API key.");

            return Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(_userName + ":" + _password));
        }
    }
}
