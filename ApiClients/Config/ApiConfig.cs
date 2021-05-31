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
        public string Login { get; set; }
        public string UserList { get; set; }
        public string UserRegiester { get; set; }
        public string UserUpdatePassword { get; set; }
        public string UserResetPassword { get; set; }
        public string UserDelete { get; set; }
        public string SearchClientUrl{ get; set; }
        public string ExportClientUrl { get; set; }
        public string ExportCSVUrl { get; set; }
        public string CountClientUrl { get; set; }

    }
}
