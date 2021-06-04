using System;
using System.Windows.Forms;
using TemperatureTool.Utilities;
using TemperatureTool.Utilitiess;

namespace TemperatureTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            SystemUtils.CreateUserDefault();
            FilesUtils.CreateDefaultConfig(Constants.ConfigPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureToolMain());
        }
    }
}
