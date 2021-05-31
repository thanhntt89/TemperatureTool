using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TemperatureTool.Models;

namespace TemperatureTool.ApiClients.Actions
{
    public class ExportActions
    {
        [Serializable]
        public class ExportRequest
        {
            [JsonProperty("fields")]
            public List<string> Fields { get; set; }
            [JsonProperty("from_date")]
            public string FromDate { get; set; }
            [JsonProperty("to_date")]
            public string ToDate { get; set; }
            [JsonProperty("users")]
            public List<string> Users { get; set; }
        }

        public class ExportResponse
        {
            [JsonProperty("list")]
            public List<DataExport> DataExports { get; set; }
        }

    }
}
