using ChoETL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemperatureTool.Models;

namespace TemperatureTool
{
    public class CSVExportBusiness
    {
        private string[] FIELDS_ALL_DEFAULT_INDEX = new string[] { "user_id", "date", "temp", "weight", "menstruation", "abnormal_bleeding", "poor_physical_condition", "sexual_intercourse", "vaginal_discharge", "lack_sleep", "drinking_alcohol", "motion", "vacation", "commuting_hospital", "taking_medicine", "feel_sick", "mood_norma", "feel_sick", "memo" };
        private string[] FIELDS_ALL_RAW_DEFAULT_INDEX = new string[] { "user_id", "date", "time", "cal_temp", "data_flg" };
        private string[] FIELDS_ALL_RAW_TF_DEFAULT_INDEX = new string[] { "user_id", "date", "time", "skin_temp", "outsite_temp", "cal_temp", "start_flag", "end_flag", "data_flg" };

        public void Export(DataExportCollection exportCollection, FileExport exportInfo)
        {
            try
            {
                string[] headerAll = new string[] { "index" }.Concat(exportCollection.ExportFileds.Concat(FIELDS_ALL_DEFAULT_INDEX)).ToArray();
                string[] headerAll_Raw = new string[] { "index" }.Concat(exportCollection.ExportFileds.Concat(FIELDS_ALL_RAW_DEFAULT_INDEX)).ToArray();
                string[] headerAll_RawTF = new string[] { "index" }.Concat(exportCollection.ExportFileds.Concat(FIELDS_ALL_RAW_TF_DEFAULT_INDEX)).ToArray();

                WriteToCSV(exportCollection, exportInfo.GetFilePathAll, headerAll);
                WriteToCSV(exportCollection, exportInfo.GetFilePathAllRaw, headerAll_Raw);
                WriteToCSV(exportCollection, exportInfo.GetFilePathAllRawTf, headerAll_RawTF);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void WriteToCSV(DataExportCollection exportCollection, string filePath, string[] exportFields)
        {
            List<string> exportHeaderText = exportCollection.GetHeaders(exportFields);
            using (var w = new ChoCSVWriter(filePath)
                .WithFirstLineHeader()
                .WithFields(exportFields))
            {
                w.Configuration.Encoding = Encoding.BigEndianUnicode;
                w.WriteHeader(exportHeaderText.ToArray());
                w.Write(exportCollection.DataExports);
            }
        }

    }
}

