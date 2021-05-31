namespace TemperatureTool.Models
{
    public class FileExport
    {
        public string StartDateTime { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Suffix { get; set; }
        public string FolderPath { get; set; }
        public string GetFilePathAll
        {
            get
            {
                return string.Format("{0}\\{1}_{2}_{3}_{4}.csv", FolderPath, StartDateTime, StartDate, EndDate, Suffix);
            }
        }

        public string GetFilePathAllRawTf
        {
            get
            {
                return string.Format("{0}\\{1}_{2}_{3}_{4}_rawtf.csv", FolderPath, StartDateTime, StartDate, EndDate, Suffix);
            }
        }

        public string GetFilePathAllRaw
        {
            get
            {
                return string.Format("{0}\\{1}_{2}_{3}_{4}_raw.csv", FolderPath, StartDateTime, StartDate, EndDate, Suffix);
            }
        }
    }
}
