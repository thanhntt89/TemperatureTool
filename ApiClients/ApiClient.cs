using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TemperatureTool.ApiClients.Abstract;
using TemperatureTool.ApiClients.Enums;
using TemperatureTool.ApiClients.Interfaces;
using TemperatureTool.ApiClients.Utilitiess;

namespace TemperatureTool.ApiClients
{
    public class ApiClient : ApiClientAbstract, IApiClient
    {
        public ApiClient(string apiKey = null, string apiSecret = null, string apiUrl = "https://sgd8ee3kf5.execute-api.ap-northeast-1.amazonaws.com/Prod/") : base(apiKey, apiSecret, apiUrl)
        {

        }

        public async Task<T> CallAsync<T>(ApiMethod apiMethod, string endPoint, string body = null, string parameters = null)
        {
            var request = new HttpRequestMessage(Utils.CreateHttpMethod(apiMethod.ToString()), endPoint);

            if (!string.IsNullOrWhiteSpace(CurrentToken))
            {
                request.Headers.Add("Token", CurrentToken);
                request.Headers.Add("X-WATASHINOONDO-SIGNATURE", CurrentToken);
            }

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = new HttpResponseMessage();

            using (var stringContent = new StringContent(body, Encoding.UTF8, "application/json"))
            {
                request.Content = stringContent;
                response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            }

            if (response.IsSuccessStatusCode)
            {
                // Api return is OK
                response.EnsureSuccessStatusCode();

                // Get the result
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                // Serialize and return result
                return JsonConvert.DeserializeObject<T>(result);
            }

            // We received an error
            if (response.StatusCode == HttpStatusCode.GatewayTimeout)
            {
                throw new Exception("Api Request Timeout.");
            }

            // Get te error code and message
            var e = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            // Error Values
            var eCode = 0;
            string eMsg = "";
            if (e.IsValidJson())
            {
                try
                {
                    var i = JObject.Parse(e);

                    eCode = i["code"]?.Value<int>() ?? 0;
                    eMsg = i["msg"]?.Value<string>();
                }
                catch { }
            }

            throw new Exception(string.Format("Api Error Code: {0} Message: {1}", eCode, eMsg));
        }
    }
}
