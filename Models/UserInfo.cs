using System;
using System.Collections.Generic;

namespace TemperatureTool.Models
{
    public class UerDisplay
    {
        public int No { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DelDate { get; set; }
        public string ActionEdit { get { return "変更"; } }
        public string ActionResetPassowrd { get { return "リセット"; } }
        public string ActionDelete { get { return "削除"; } }
    }

    [Serializable]
    public class UserInfo
    {
        public int No { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string SandN { get; set; }
        public string ZipCode { get; set; }
        public string Password { get; set; }
        public int PasswordReset { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DelDate { get; set; }
        public string Pds { get; set; }
        public int Authy { get; set; }
        public IList<Role> Roles { get; set; }
        public IList<Role> RolesOut { get; set; }
    }

    [Serializable]
    public class Role
    {
        public int RoldeId { get; set; }
        public string RoleName { get; set; }
    }

}
