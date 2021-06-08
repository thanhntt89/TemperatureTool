using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TemperatureTool
{
    [RunInstaller(true)]
    public partial class InstallerTemperature : Installer
    {
        private string produceName = Assembly.GetExecutingAssembly().GetName().Name;
        private static string produceLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public InstallerTemperature()
        {
            InitializeComponent();
        }

        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            Process application = null;
            try
            {
                foreach (var process in Process.GetProcesses())
                {
                    if (!process.ProcessName.ToLower().Contains("creatinginstaller"))
                    {
                        continue;
                    }

                    application = process;

                    break;
                }

                if (application != null && application.Responding)
                {
                    application.Kill();
                }

                Delete();
            }
            catch
            {

            }
        }

        private void Delete()
        {
            List<string> listFile = Directory.GetFiles(produceLocation).ToList();
            List<string> listDelete = new List<string>();
            try
            {
                string[] subDirectory = Directory.GetDirectories(produceLocation);
                // Delete sub folder
                foreach (var folder in subDirectory)
                {
                    try
                    {
                        Directory.Delete(folder, true);
                    }
                    catch
                    {

                    }
                }

                string[] ignor = new string[] { "TemperatureTool" };
                //Delete file              
                if (ignor != null)
                {
                    foreach (string file in listFile)
                    {
                        string fileName = Path.GetFileName(file);
                        if (ignor.Contains(fileName))
                            continue;
                        listDelete.Add(file);
                    }
                }
                else
                {
                    listDelete = listFile;
                }

                foreach (var file in listDelete)
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch
                    {

                    }
                }               
            }
            catch
            {

            }
        }
    }
}
