using Newtonsoft.Json;
using System.Collections.Generic;

namespace TemperatureTool.ApiClients.Actions
{
    public class UserActions
    {
        #region UserList
        public class UserListRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
        }

        public class UserListResponse
        {
            [JsonProperty("users")]
            public IEnumerable<User> Users { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }

            public void InitList()
            {
                int index = 0;
                foreach (var item in Users)
                {
                    index++;
                    item.No = index;
                }
            }
        }

        #endregion

        #region UserRegisterRequest
        public class UserRegisterRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
        }

        public class UserRegisterResponse
        {
            [JsonProperty("user_id")]
            public int UserId { get; set; }
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }
        #endregion

        #region UserChangePassword
        public class UserChangePasswordRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
            [JsonProperty("old_password")]
            public string OldPassword { get; set; }
            [JsonProperty("new_password")]
            public string NewPassword { get; set; }
        }

        public class UserChangePasswordResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }

        #endregion

        #region UserDeleteRequest
        public class UserDeleteRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

        }

        public class UserDeleteResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }

        #endregion

        #region UserResetPassword
        public class UserResetPasswordRequest
        {
            [JsonProperty("login_id")]
            public int LoginId { get; set; }
            [JsonProperty("user_id")]
            public int UserId { get; set; }
        }

        public class UserResetPasswordResponse
        {
            [JsonProperty("status")]
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
        }
        #endregion

    }


    public class User
    {
        public int No { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("reg_date")]
        public string CreatedDate { get; set; }       
        [JsonProperty("user_roles")]
        public IList<Role> Roles { get; set; }
        [JsonProperty("upd_date")]
        public string UpdatedDate { get; set; }       
    }

    public class Role
    {
        [JsonProperty("role_id")]
        public int RoldeId { get; set; }
        [JsonProperty("role_name")]
        public string RoleName { get; set; }
    }
}
