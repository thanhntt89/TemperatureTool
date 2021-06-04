using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using static TemperatureTool.ApiClients.TokenDataContract;
using TemperatureTool.ApiClients.Utils;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Security.Cryptography;

namespace TemperatureTool.ApiClients.Abstract
{
    public abstract class ApiClientAbstract
    {
        public readonly string _apiUrl = string.Empty;
        public readonly string _apiKey = string.Empty;
        public readonly string _apiSecret = string.Empty;

        public readonly HttpClient _httpClient;

        // **************************************************
        // 公開鍵
        public static string PUBLIC_KEY;
        // 秘密鍵
        public static string PRIVATE_KEY;
        // APIキー
        public static string API_KEY;

        // PDS URL
        public static string PDS_URL;

        // Company ID
        public static string COMPANY_ID;
        // Group ID
        public static string GROUP_ID;
        //CurrentToken
        public static string CurrentToken;

        // **************************************************

        /// <summary>
        /// Define the contructor of the api client
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="apiSecret"></param>
        /// <param name="apiUrl"></param>
        public ApiClientAbstract(string apiKey = null, string apiSecret = null, string apiUrl = "")
        {
            _apiUrl = apiUrl;
            _apiKey = apiKey;
            _apiSecret = apiSecret;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(_apiUrl)                
            };
            _httpClient.Timeout = TimeSpan.FromMinutes(15);
            ConfigureHttpClient();

            EmvironmentContext.PDS_URL_RELEASE = apiUrl;
            //  EmvironmentContext.PDS_API_KEY_RELEASE = apiKey;
            //CurrentToken = GetToken();
        }

        /// <summary>
        /// Configures the HTTPClient.
        /// </summary>
        private void ConfigureHttpClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Init header
        /// </summary>
        private static void InitApiKey()
        {
            // **** 環境判定 ****
            if (EmvironmentContext.ENVIRONMENT_MODE == EmvironmentContext.RELEASE)
            {
                //************************* Release *************************
                // 公開鍵
                PUBLIC_KEY = EmvironmentContext.PUBLIC_KEY_RELEASE;
                // 秘密鍵
                PRIVATE_KEY = EmvironmentContext.PRIVATE_KEY_RELEASE;
                // APIキー
                API_KEY = EmvironmentContext.API_KEY_RELEASE;

                // PDS URL
                PDS_URL = EmvironmentContext.PDS_URL_RELEASE;

                // Company ID
                COMPANY_ID = EmvironmentContext.PDS_COMPANY_ID_RELEASE;
                // Group ID
                GROUP_ID = EmvironmentContext.PDS_GROUP_ID_RELEASE;

            }
            else
            {
                //************************* Dev *************************
                // 公開鍵
                PUBLIC_KEY = EmvironmentContext.PDS_PUBLIC_KEY_DEV;
                // 秘密鍵
                PRIVATE_KEY = EmvironmentContext.PDS_PRIVATE_KEY_DEV;
                // APIキー
                API_KEY = EmvironmentContext.PDS_API_KEY_DEV;

                // PDS URL
                PDS_URL = EmvironmentContext.PDS_URL_DEV;

                // Company ID
                COMPANY_ID = EmvironmentContext.PDS_COMPANY_ID_DEV;
                // Group ID
                GROUP_ID = EmvironmentContext.PDS_GROUP_ID_DEV;
            }
        }

        // TOKEN発行
        public static string GetToken()
        {
            // 初期処理
            InitApiKey();

            // 現在時刻
            DateTime dt = DateUtil.NowJst();
            string now = dt.ToString("yyyy/MM/dd HH:mm:ss.fff");
            // 暗号化対象テキスト
            string text = API_KEY + now;

            // code1(公開鍵で暗号化)
            string c1 = EncryptUtil.Encrypt(text, PUBLIC_KEY, true);

            // code2(秘密鍵で暗号化)
            string c2 = EncryptUtil.Encrypt(c1, PRIVATE_KEY, false);

            // ***********************:
            string apiUrl = PDS_URL + "/certificate";

            // データの作成
            var code = new TokenCode()
            {
                Code1 = c1,
                Code2 = c2,
            };

            string jsonStr = null;

            using (var ms = new MemoryStream())
            using (var sr = new StreamReader(ms))
            {
                var serializer = new DataContractJsonSerializer(typeof(TokenCode));
                serializer.WriteObject(ms, code);
                ms.Position = 0;

                jsonStr = sr.ReadToEnd();

            }

            RequestResult result = PdsResponse("POST", apiUrl, now, $"{jsonStr}", null);
            if (result.Status == "NG")
            {
                throw new Exception();
            }

            return result.Token;
        }

        // PDS接続共通処理
        private static RequestResult PdsResponse(string method, string apiUrl, string timestamp, string jsonParameter, string token)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
                request.ContentType = "application/json";
                request.Method = method;
                // カスタムヘッダー
                request.Headers.Add("CompanyID", COMPANY_ID);
                request.Headers.Add("GroupID", GROUP_ID);
                request.Headers.Add("TimeStamp", timestamp);
                if (token != null)
                {
                    request.Headers.Add("Token", token);
                }

                if (jsonParameter != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(jsonParameter);
                    }
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();

                // HttpStatusCodeの判断
                if (httpResponse.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                RequestResult result;
                using (httpResponse)
                {
                    using (var resStream = httpResponse.GetResponseStream())
                    {

                        var serializer = new DataContractJsonSerializer(typeof(RequestResult));

                        result = (RequestResult)serializer.ReadObject(resStream);

                    }
                    return result;
                }
            }
            catch (WebException)
            {
                throw new Exception();
            }
        }

        public static HttpMethod CreateHttpMethod(string method)
        {
            switch (method.ToUpper())
            {
                case "DELETE":
                    return HttpMethod.Delete;
                case "POST":
                    return HttpMethod.Post;
                case "PUT":
                    return HttpMethod.Put;
                case "GET":
                    return HttpMethod.Get;
                default:
                    throw new NotImplementedException();
            }
        }

        public static HttpContent CreateHttpContent(object content)
        {
            HttpContent httpContent = null;

            if (content != null)
            {
                var ms = new MemoryStream();
                SerializeJsonIntoStream(content, ms);
                ms.Seek(0, SeekOrigin.Begin);
                httpContent = new StreamContent(ms);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            return httpContent;
        }

        private static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using (var sw = new StreamWriter(stream, new UTF8Encoding(false), 1024, true))
            using (var jtw = new JsonTextWriter(sw) { Formatting = Formatting.None })
            {
                var js = new JsonSerializer();
                js.Serialize(jtw, value);
                jtw.Flush();
            }
        }

        /// <summary>
        /// Gets a HMACSHA256 signature based on the API Secret.
        /// </summary>
        /// <param name="apiSecret">Api secret used to generate the signature.</param>
        /// <param name="message">Message to encode.</param>
        /// <returns></returns>
        public static string GenerateSignature(string apiSecret, string message)
        {
            var key = Encoding.Default.GetBytes(apiSecret);
            string stringHash;
            using (var hmac = new HMACSHA256(key))
            {
                var hash = hmac.ComputeHash(Encoding.Default.GetBytes(message));
                stringHash = Convert.ToBase64String(hash).TrimEnd('=');
            }

            return stringHash;
        }
    }
}
