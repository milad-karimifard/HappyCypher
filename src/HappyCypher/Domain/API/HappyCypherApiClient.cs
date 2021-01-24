using HappyCypher.Domain.Exception;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HappyCypher.Domain.API
{
    public class HappyCypherApiClient
    {
        private HttpClient _client { get; set; }

        public HappyCypherApiClient(HttpClient client)
        {
            ConfigureClient(_client);
        }

        #region private method

        private void ConfigureClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.blockcypher.com/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client = client;
        }

        private async Task<TResult> DoPostPutAsync<TInput,TResult>(HttpMethod method, string uri, TInput item, List<(string, string)> headers = null)
        {
            if (method != HttpMethod.Post && method != HttpMethod.Put)
            {
                throw new ArgumentException("Value must be either post or put.", nameof(method));
            }

            var requestMessage = new HttpRequestMessage(method, uri);

            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(item), System.Text.Encoding.UTF8, "application/json");


            if (headers != null && headers.Any())
            {
                foreach (var head in headers)
                {
                    requestMessage.Headers.Add(head.Item1, head.Item2);
                }
            }

            var response = await _client.SendAsync(requestMessage);

            HandleRequestStatus(response.StatusCode);

            return await MapToModel<TResult>(response);
        }

        private void HandleRequestStatus(HttpStatusCode statusCode)
        {
            if (statusCode == HttpStatusCode.OK) return;

            if (statusCode == HttpStatusCode.TooManyRequests) throw new CypherRateLimitException();
            else throw new HttpRequestException(statusCode.ToString());
        }

        private async Task<TResult> MapToModel<TResult>(HttpResponseMessage response)
        {
            try
            {
                string body = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<TResult>(body);
            }
            catch
            {
                throw new JsonDeserializeException();
            }
        }

        #endregion

        #region public methods

        public async Task<TResult> GetAsync<TResult>(string uri)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await _client.SendAsync(requestMessage);
            return await MapToModel<TResult>(response);
        }

        public async Task<TResult> PostAsync<TInput, TResult>(string uri, TInput item, List<(string, string)> headers = null)
        {
            return await DoPostPutAsync<TInput,TResult>(HttpMethod.Post, uri, item, headers);
        }

        public async Task<TResult> PutAsync<TInput, TResult>(string uri, TInput item)
        {
            return await DoPostPutAsync<TInput, TResult>(HttpMethod.Put, uri, item);
        }

        public async Task<TResult> DeleteAsync<TResult>(string uri)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);
            var response = await _client.SendAsync(requestMessage);

            return await MapToModel<TResult>(response);
        }

        #endregion
    }
}
