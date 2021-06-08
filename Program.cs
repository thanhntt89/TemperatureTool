using System;
using System.Windows.Forms;
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
            SystemConfigDefault.CreateUserDefault();
            SystemConfigDefault.CreateEndpointDefault(Constants.ConfigPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TemperatureToolMain());
        }
    }
}
