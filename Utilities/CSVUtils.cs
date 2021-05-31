using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace TemperatureTool.Utilities
{
    public class CSVUtils
    {
        public static void SaveToCsv<T>(List<T> reportData, string path, string[] headers = null)
        {
            var lines = new List<string>();
            IEnumerable<PropertyDescriptor> props = TypeDescriptor.GetProperties(typeof(T)).OfType<PropertyDescriptor>();
            var header = string.Join(",", headers.ToList().Select(x => x));
            lines.Add(header);
            var valueLines = reportData.Select(row => string.Join(",", header.Split(',').Select(a => row.GetType().GetProperty(a).GetValue(row, null))));
            lines.AddRange(valueLines);
            File.WriteAllLines(path, lines.ToArray());
        }
    }
}
