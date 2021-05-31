using System.Windows.Forms;

namespace TemperatureTool
{
    public static class Constants
    {
        public static string ResponseStatusSuccess = "OK";
        public static string ResponseStatusFails = "NG";

        public static string SystemAdminUser = "administrator";
        public static string SystemAdminPassowrd = "admin_0123456";

        public static string RoleSearchName = "名前";
        public static string RoleSearchDoB = "生年月日";
        public static string RoleSearchZipCode = "郵便番号";
        public static string RoleSearchEmail = "メールアドレス";
        public static string RoleSearchSandD = "S/N";
        public static string RoleExportData = "データ抽出";
        public static string RoleCreatedList = "対象者リスト作成";

        public static string ERROR_TITLE = "エラー";
        public static string INFO_TITLE = "情報";
        public static string WARNING_TITLE = "確認";

        public static int LoginId { get; set; }
        public static string LoginName { get; set; }

        public static string SearchingHistoriesFilePath = string.Format("{0}\\{1}", Application.StartupPath, "SearchingHistories.dat");

        public static string ConfigPath = string.Format("{0}\\{1}", Application.StartupPath, "Config.dat");
        public static string UserDataPath = string.Format("{0}\\{1}", Application.StartupPath, "t_admin.dat");
        public static string LogSystemPath = string.Format("{0}\\{1}", Application.StartupPath, "log.dat");
        public static string ExportClientFileName = "export_clients.csv";

        public static string Suffix_All = "ALL";
        public static string Suffix_UserId = "ユーザーID";


    }
}
