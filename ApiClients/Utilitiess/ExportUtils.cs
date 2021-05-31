using ChoETL;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TemperatureTool.Models;

namespace TemperatureTool.Utilities
{
    public class ExportUtils
    {
        public static void ToCSV(List<Client> clients, IList<string> headers, string filePath)
        {
            if (clients == null || clients.Count == 0) 
                return;

            using (var w = new ChoCSVWriter<Client>(filePath).WithFirstLineHeader())
            {
                w.WriteHeader(headers.ToArray());
                w.Write(clients);
            }
        }

        public static IList<string> GetHeaderList(DataGridView gridView)
        {
            List<string> header = new List<string>();
            foreach (DataGridViewColumn hd in gridView.Columns)
            {
                header.Add(Regex.Replace(hd.HeaderText, @"\t|\n|\r", ""));
            }

            return header;
        }
    }
}
