using System.Collections.Generic;
using System.IO;
using TemperatureTool.ApiClients.Config;
using TemperatureTool.Bussiness;
using TemperatureTool.Models;
using TemperatureTool.Utilitiess;

namespace TemperatureTool.Utilities
{
    public class SystemConfigDefault
    {     
        internal static void CreateUserDefault()
        {
            if (File.Exists(Constants.UserDataPath))
                return;
            try
            {
                FilesUtils.SerializeObjectToBinary<List<UserInfo>>(UserBusiness.Users, Constants.UserDataPath);
            }
            catch
            {

            }
        }

        internal static void CreateEndpointDefault(string filePath)
        {
            if (File.Exists(filePath))
                return;         

            ApiConfig apiConfig = new ApiConfig()
            {
                ApiInfos = new ApiInfo()
                {
                    ApiKey = "xxx",
                    ApiSecret = "YXdQqqC8jaPCo9FGT7efHbZP15T14Nxn",
                    ApiUrl = "https://s71997spa3.execute-api.ap-northeast-1.amazonaws.com",
                    EnpointInfo = new EndPointInfo()
                    {
                        LoginUrl = "/Prod/user/login",
                        UsersUrl = "/api/users/count",
                        UserRegiesterUrl = "/Prod/user/register",
                        UserUpdatePasswordUrl = "/Prod/user/updatepassword",
                        UserResetPasswordUrl = "/Prod/user/resetpassword",
                        UserDeleteUrl = "/Prod/user/delete",
                        CountClientUrl = "/Prod/users/count",
                        SearchClientUrl = "/Prod/user/list",
                        ExportClientUrl = "/Prod/users/export",
                        ExportCSVUrl = "/Prod/user/export"
                    }
                }                
            };
            try
            {
                FilesUtils.SerializeObject<ApiConfig>(apiConfig, filePath);
            }
            catch
            {

            }
        }
    }
}
