using System;
using System.IO;
using System.Windows.Forms;
using TemperatureTool.ApiClients.Utilitiess;
using TemperatureTool.Models;
using TemperatureTool.Utilities;

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
            Utils.CreateDefaultConfig(Constants.ConfigPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureToolMain());
        }
    }
}
