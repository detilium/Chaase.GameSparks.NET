using GameSparks.NET.Authentication.Infrastructure.Exceptions;
using GameSparks.NET.Authentication.Infrastructure.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameSparks.NET.Authentication.Infrastructure
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

        internal static GameSparksResponse PostString(string url, string requestData)
        {
            var req = BuildRequest(url, HttpMethod.Post, requestData);

            return ExecuteSynchronousRequest(req);
        }

        internal static GameSparksResponse DeleteString(string url)
        {
            var req = BuildRequest(url, HttpMethod.Delete);

            return ExecuteSynchronousRequest(req);
        }

        internal static GameSparksResponse PutString(string url, string requestData)
        {
            var req = BuildRequest(url, HttpMethod.Put, requestData);

            return ExecuteSynchronousRequest(req);
        }

        private static GameSparksResponse ExecuteSynchronousRequest(HttpRequestMessage request)
        {
            var response = HttpClient.SendAsync(request).Result;
            var responseText = response.Content.ReadAsStringAsync().Result;

            var result = BuildResponseData(response, responseText);

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.Forbidden)
                    throw new GameSparksRequestException("API key, credential type or secret not valid");
                if (response.StatusCode == HttpStatusCode.NotFound)
                    throw new GameSparksRequestException("Not Found");
                else
                    throw new GameSparksRequestException("The request was unsuccessfull. Make sure that you are sending valid data if the request is a PSOt or PUT HTTP request.");
            }

            return result;
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

        internal static async Task<GameSparksResponse> DeleteStringAsync(string url, CancellationToken cancellationToken = default(CancellationToken))
        {
            var req = BuildRequest(url, HttpMethod.Delete);

            return await ExecuteAsynchronousRequest(req, cancellationToken);
        }

        internal static async Task<GameSparksResponse> PutStringAsync(string url, string requestData, CancellationToken cancellationToken = default(CancellationToken))
        {
            var req = BuildRequest(url, HttpMethod.Put, requestData);

            return await ExecuteAsynchronousRequest(req, cancellationToken);
        }

        private static async Task<GameSparksResponse> ExecuteAsynchronousRequest(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await HttpClient.SendAsync(request, cancellationToken);
            var responseText = await response.Content.ReadAsStringAsync();
            
            var result = BuildResponseData(response, await response.Content.ReadAsStringAsync());

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.Forbidden)
                    throw new GameSparksRequestException("API key, credential type or secret not valid");
                if (response.StatusCode == HttpStatusCode.NotFound)
                    throw new GameSparksRequestException("Not Found");
                else
                    throw new GameSparksRequestException("The request was unsuccessfull. Make sure that you are sending valid data if the request is a PSOt or PUT HTTP request.");
            }

            return result;
        }
        #endregion

        #region Helpers
        private static HttpRequestMessage BuildRequest(string url, HttpMethod method, string requestData = null)
        {
            var request = new HttpRequestMessage(method, new Uri(url));
            request.Headers.Add("Authorization", "Basic " + GameSparksAuthenticationSettings.GetBasicAuthenticationHeaderValue());

            // HttpGet
            if (method == HttpMethod.Get)
                return request;

            // HttpDelete
            if(method == HttpMethod.Delete)
            {
                request.Method = HttpMethod.Delete;
                return request;
            }

            // HttpPut
            if (method == HttpMethod.Put)
                request.Method = HttpMethod.Put;

            // HttpPost
            else
                request.Method = HttpMethod.Post;

            request = new HttpRequestMessage(method, new Uri(url))
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
