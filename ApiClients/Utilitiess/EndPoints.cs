namespace TemperatureTool.ApiClients.Utilitiess
{
    public static class EndPoints
    {        
        #region User endpoints
        public static readonly string Login = "/Prod/user/login";        
        public static readonly string UserList = "/Prod/user";
        public static readonly string UserRegiester = "/Prod/user/register";
        public static readonly string UserUpdatePassword = "/Prod/user/updatepassword";
        public static readonly string UserResetPassword = "/Prod/user/resetpassword";
        public static readonly string UserDelete = "/Prod/user/delete";
        #endregion

        #region Client endpoints
        public static readonly string ClientList = "/Prod/client";
        public static readonly string ClientExport = "/Prod/client/export";
        #endregion

    }
}
