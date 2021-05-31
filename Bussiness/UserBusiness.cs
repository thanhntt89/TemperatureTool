using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TemperatureTool.ApiClients.Actions;
using TemperatureTool.ApiClients.Utilitiess;
using TemperatureTool.Models;
using static TemperatureTool.ApiClients.Actions.LoginActions;
using static TemperatureTool.ApiClients.Actions.UserActions;
using Role = TemperatureTool.Models.Role;

namespace TemperatureTool.Bussiness
{
    public class UserBusiness
    {
        private UserBusiness()
        {

        }

        private static readonly string AdminUserDefault = Constants.SystemAdminUser;
        private static readonly string PasswordAdminDefault = Constants.SystemAdminPassowrd;
        private static readonly int AdminId = 1;

        public static List<UserInfo> Users = new List<UserInfo>();

        public static List<UerDisplay> GetUsers()
        {
            List<UerDisplay> uerDisplays = new List<UerDisplay>();
            int index = 0;
            foreach (var item in Users)
            {
                index++;
                uerDisplays.Add(new UerDisplay()
                {
                    No = index,
                    UserId = item.UserId,
                    UserName = item.UserName
                });
            }

            return uerDisplays;
        }

        public static void Add(UserInfo user)
        {
            user.UserId = Users.Count + 1;
            user.PasswordReset = 1;
            user.Authy = 2;
            Users.Add(user);
            Save();
        }

        public static void Update(UserInfo user)
        {
            var exist = GetUserById(user.UserId);

            if (exist == null)
                return;

            exist.UserName = user.UserName;
            exist.Password = user.Password;
            exist.PasswordReset = user.PasswordReset;
            exist.RegDate = user.RegDate;
            exist.UpdateDate = user.UpdateDate;
            exist.Pds = user.Pds;
            exist.DelDate = user.DelDate;
            exist.Authy = user.Authy;
            exist.Roles = user.Roles;
            exist.RolesOut = user.RolesOut;
            Save();
        }

        public static void UpdateRole(UserInfo user)
        {
            var exist = GetUserById(user.UserId);

            if (exist == null)
                return;
            exist.Roles = user.Roles;
            exist.RolesOut = user.RolesOut;
            Save();
        }


        public static void Delete(int userId)
        {
            var exist = GetUserById(userId);
            if (exist != null)
                Users.Remove(exist);

            Save();
        }

        public static bool CheckRoleExist(IList<Role> roles, string roleName)
        {
            var exist = roles.ToList().Where(r => r.RoleName.Equals(roleName)).ToList();

            if (exist.Count() == 1)
            {
                return true;
            }

            return false;
        }

        public static int GetUserIdByUserName(string userName)
        {
            var exist = Users.Where(r => r.UserName.Equals(userName)).FirstOrDefault();
            return exist == null ? -1 : exist.UserId;
        }

        public static UserInfo GetUserById(int userId)
        {
            var exist = Users.Where(r => r.UserId == userId).FirstOrDefault();
            if (exist == null)
            {
                return null;
            }

            return exist;
        }

        public static LoginResponse CheckLoginResponse(LoginRequest loginRequest)
        {
            LoginResponse response = new LoginResponse();

            if (loginRequest.UserName.Equals(AdminUserDefault))
            {
                if (loginRequest.Password.Equals(PasswordAdminDefault))
                {
                    response.Status = "OK";
                    response.AdminFlg = 1;
                    response.UserId = AdminId;
                    response.Roles = Roles.GeteRolesDefault();
                }
                else
                {
                    response.Status = "NG";
                    response.ErrorInfo = new ErrorInfo() { Message = "ログインIDとパスワードが一致しません。!!!" };
                }
            }
            else
            {
                var exist = Users.Where(r => r.UserName.Equals(loginRequest.UserName) && r.Password.Equals(loginRequest.Password)).FirstOrDefault();
                if (exist != null)
                {
                    response.Status = "OK";
                    response.AdminFlg = 0;
                    response.UserId = exist.UserId;
                    response.ChangePasswordFlg = exist.PasswordReset;

                    var userRlose = new List<LoginActions.Role>();

                    foreach (var item in exist.Roles)
                    {
                        userRlose.Add(new LoginActions.Role()
                        {
                            RoldeId = item.RoldeId,
                            RoleName = item.RoleName
                        });
                    }

                    response.Roles = userRlose;
                }
                else
                {
                    response.Status = "NG";
                    response.ErrorInfo = new ErrorInfo() { Message = "ログインIDとパスワードが一致しません。!!!" };
                }
            }
            return response;
        }

        public static UserChangePasswordResponse ChangePasswordResponse(UserChangePasswordRequest request)
        {
            UserChangePasswordResponse response = new UserChangePasswordResponse();
            var exist = Users.Where(r => r.UserId == request.LoginId && r.Password.Equals(request.OldPassword)).FirstOrDefault();
            if (exist != null)
            {
                exist.Password = request.NewPassword;
                exist.PasswordReset = 0;
                exist.PasswordReset = 0;
                Update(exist);
                response.Status = "OK";

                Save();
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "現在のパスワードが間違いました。" };
            }

            return response;
        }

        public static UserRegisterResponse RegisterUserResponse(UserRegisterRequest request)
        {
            UserRegisterResponse response = new UserRegisterResponse();

            if (request.LoginId == AdminId)
            {
                string userName = CreateUserName();
                response.Status = "OK";

                Add(new UserInfo()
                {
                    UserName = userName,
                    Password = userName,
                    PasswordReset = 1,
                    UpdateDate = DateTime.Now,
                    RegDate = DateTime.Now,
                    Authy = 2
                });

                response.UserId = GetUserIdByUserName(userName);

                Save();
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!!" };
            }
            return response;
        }

        public static UserListResponse GetUserListResponse(UserListRequest request)
        {
            UserListResponse response = new UserListResponse();
            List<User> users = new List<User>();
            foreach (UserInfo user in Users)
            {
                users.Add(new User()
                {
                    UserId = user.UserId,
                    UserName = user.UserName,
                    UpdatedDate = user.UpdateDate.ToString("yyy/MM/dd HH:mm:ss"),
                    CreatedDate = user.RegDate.ToString("yyy/MM/dd HH:mm:ss")
                });
            }
            response.Status = "OK";
            response.Users = users;
            Save();
            return response;
        }

        public static UserDeleteResponse DeleteUserResponse(UserDeleteRequest request)
        {
            UserDeleteResponse response = new UserDeleteResponse();
            if (request.LoginId == AdminId)
            {
                response.Status = "OK";
                Delete(request.UserId);
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!" };
            }

            return response;
        }

        public static UserResetPasswordResponse ResetPasswordResponse(UserResetPasswordRequest request)
        {
            UserResetPasswordResponse response = new UserResetPasswordResponse();
            if (request.LoginId == AdminId)
            {
                response.Status = "OK";
                var exist = GetUserById(request.UserId);
                if (exist != null)
                {
                    exist.Password = exist.UserName;
                    exist.PasswordReset = 1;
                    exist.UpdateDate = DateTime.Now;
                }

                Save();
            }
            else
            {
                response.Status = "NG";
                response.ErrorInfo = new ErrorInfo() { Message = "You don't have permission!!" };
            }

            return response;
        }

        public static string CreateUserName()
        {
            int maxLength = 8;
            string preFix = "TF";
            string userName = string.Empty;
            int maxId = Users.Count + 1;
            int pad = maxLength - preFix.Length;
            userName = string.Format("{0}{1}", preFix, maxId.ToString().PadLeft(pad, '0'));

            var exist = Users.Where(r => r.UserName.Equals(userName)).FirstOrDefault();

            if (exist != null)
            {
                CreateUserName();
                Save();
            }
            return userName;
        }

        public static void Save()
        {
            Utils.SerializeObjectToBinary<List<UserInfo>>(Users, Constants.UserDataPath);
        }
    }
}
