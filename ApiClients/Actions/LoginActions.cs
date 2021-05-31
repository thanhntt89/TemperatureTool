using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TemperatureTool.ApiClients.Actions
{
    public class LoginActions
    {
        [Serializable]
        public class LoginRequest
        {
            [JsonProperty("user_name")]
            public string UserName { get; set; }
            [JsonProperty("password")]
            public string Password { get; set; }
        }

        [Serializable]
        public class LoginResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("user_id")]
            public int UserId { get; set; }
            [JsonProperty("change_password_flg")]
            public int ChangePasswordFlg { get; set; }
            [JsonProperty("admin_flg")]
            public int AdminFlg { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
            [JsonProperty("user_roles")]
            public List<Role> Roles { get; set; }
        }

        public class Role
        {
            [JsonProperty("role_id")]
            public int RoldeId { get; set; }
            [JsonProperty("role_name")]
            public string RoleName { get; set; }
        }

        public class Roles
        {
            private static List<Role> UserRoles;

            public static List<Role> GeteRolesDefault()
            {
                if (UserRoles == null)
                {
                    UserRoles = new List<Role>();

                    UserRoles.Add(new Role() { RoldeId = 1, RoleName = Constants.RoleCreatedList });
                    UserRoles.Add(new Role() { RoldeId = 2, RoleName = Constants.RoleExportData });
                }

                return UserRoles;
            }
        }
    }
}
