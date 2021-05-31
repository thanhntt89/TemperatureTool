using System;
using System.IO;

namespace TemperatureTool.Utilities
{
    public static class LogUtils
    {
        public static void WriteLog(LogInfo logInfo)
        {
            try
            {
                FileInfo file = new FileInfo(Constants.LogSystemPath);
                if (!file.Exists)
                {
                    file.Create();
                }
                using (StreamWriter outputFile = new StreamWriter(Constants.LogSystemPath))
                {
                    outputFile.WriteLine(logInfo.GetContents());
                }
            }
            catch
            {
            }
        }
    }

    public class LogInfo
    {
        public string UserName { get; set; }
        public string Action { get; set; }
        public string Notes { get; set; }
        public bool IsSuccess { get; set; }

        public string GetContents()
        {
            return string.Format("Date Time:{0}\nUser name:{1}\nAction:{2}\nNotes:{3}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), UserName, Action, Notes);
        }
    }
}
