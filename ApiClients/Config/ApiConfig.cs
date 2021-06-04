using System;

namespace TemperatureTool.ApiClients.Config
{
    [Serializable]
    public class ApiConfig
    {
        public ApiInfo ApiInfos { get; set; }

        public EndPointInfo EnpointInfo { get; set; }
    }

    [Serializable]
    public class ApiInfo
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public string ApiUrl { get; set; }
    }

    [Serializable]
    public class EndPointInfo
    {
        public string LoginUrl { get; set; }
        public string UsersUrl { get; set; }
        public string UserRegiesterUrl { get; set; }
        public string UserUpdatePasswordUrl { get; set; }
        public string UserResetPasswordUrl { get; set; }
        public string UserDeleteUrl { get; set; }
        public string SearchClientUrl{ get; set; }
        public string ExportClientUrl { get; set; }
        public string ExportCSVUrl { get; set; }
        public string CountClientUrl { get; set; }

    }
}
