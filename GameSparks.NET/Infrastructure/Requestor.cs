using GameSparks.NET.Infrastructure.Exceptions;
using GameSparks.NET.Infrastructure.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameSparks.NET.Infrastructure
{
    internal static class Requestor
    {
        internal static HttpClient HttpClient { get; private set;}

        static Requestor()
        {
            HttpClient = new HttpClient();
        }

        #region Synchronous

        internal static GameSparksResponse GetString(string url)
        {
            var req = BuildRequest(url, HttpMethod.Get);

            return ExecuteSynchronousRequest(req);
        }

        internal static GameSparksResponse PostString(string url, string data)
        {
            var req = BuildRequest(url, HttpMethod.Post, data);

            return ExecuteSynchronousRequest(req);
        }

        private static GameSparksResponse ExecuteSynchronousRequest(HttpRequestMessage request)
        {
            var response = HttpClient.SendAsync(request).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            var result = BuildResponseData(response, responseText);

            if (response.IsSuccessStatusCode)
                return result;               
            else if (response.StatusCode == HttpStatusCode.Forbidden)
                throw new GameSparksForbiddenException("API key, credential type or secret not valid");

            return null;
        }

        #endregion

        #region Asynchonous

        internal static async Task<GameSparksResponse> GetStringAsync(string url, CancellationToken cancellationToken = default(CancellationToken))
        {
            var req = BuildRequest(url, HttpMethod.Get);

            return await ExecuteAsynchronousRequest(req, cancellationToken);
        }

        internal static async Task<GameSparksResponse> PostStringAsync(string url, string requestData, CancellationToken cancellationToken = default(CancellationToken))
        {
            var req = BuildRequest(url, HttpMethod.Post, requestData);

            return await ExecuteAsynchronousRequest(req, cancellationToken);
        }

        private static async Task<GameSparksResponse> ExecuteAsynchronousRequest(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await HttpClient.SendAsync(request, cancellationToken);
            var responseText = await response.Content.ReadAsStringAsync();
            
            var result = BuildResponseData(response, await response.Content.ReadAsStringAsync());

            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.Forbidden)
                    throw new GameSparksForbiddenException("API key, credential type or secret not valid");

                return result;
            }

            return null;
        }
        #endregion

        #region Helpers
        private static HttpRequestMessage BuildRequest(string url, HttpMethod method, string requestData = null)
        {
            if (method == HttpMethod.Get)
                return new HttpRequestMessage(method, new Uri(url));

            var request = new HttpRequestMessage(method, new Uri(url))
            {
                Content = new StringContent(requestData, Encoding.UTF8, "application/json")
            };

            return request;
        }

        private static GameSparksResponse BuildResponseData(HttpResponseMessage response, string responseText)
        {
            var result = new GameSparksResponse()
            {
                ResponseJson = responseText
            };

            return result;
        }
        #endregion
    }
}
