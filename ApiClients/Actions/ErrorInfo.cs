using Newtonsoft.Json;

namespace TemperatureTool.ApiClients.Actions
{
    public class ErrorInfo
    {
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
