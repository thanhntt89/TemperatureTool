using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using TemperatureTool.Models;

namespace TemperatureTool.ApiClients.Actions
{
    public class ClientActions
    {
        [Serializable]
        public class CountClientsRequest
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("birth")]
            public string DoB { get; set; }
            [JsonProperty("postno")]
            public string PostNo { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }
            [JsonProperty("sn")]
            public string SN { get; set; }
        }

        [Serializable]
        public class CountClientsResponse
        {
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
            public int Count { get; set; }
        }

        [Serializable]
        public class SearchClientsRequest
        {
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("birth")]
            public string birth { get; set; }
            [JsonProperty("postno")]
            public string postno { get; set; }
            [JsonProperty("email")]
            public string email { get; set; }
            [JsonProperty("sn")]
            public string sn { get; set; }
            [JsonProperty("current_page")]
            public int current_page { get; set; }
            [JsonProperty("filter_name")]
            public int? filter_name { get; set; }
            [JsonProperty("filter_birth")]
            public int? filter_birth { get; set; }
            [JsonProperty("filter_postno")]
            public int? filter_postno { get; set; }
            [JsonProperty("filter_email")]
            public int? filter_email { get; set; }
            [JsonProperty("filter_sn")]
            public int? filter_sn { get; set; }
        }

        [Serializable]
        public class SearchClientsResponse
        {
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
            [JsonProperty("list")]
            public List<Client> Clients { get; set; }
            [JsonProperty("total_pages")]
            public int TotalPage { get; set; }
            [JsonProperty("current_page")]
            public int CurrentPage { get; set; }
            [JsonProperty("total_users")]
            public int TotalUsers { get; set; }
        }

        [Serializable]
        public class ExportClientsRequest
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("birth")]
            public string DoB { get; set; }
            [JsonProperty("postno")]
            public string PostNo { get; set; }
            [JsonProperty("email")]
            public string Email { get; set; }
            [JsonProperty("sn")]
            public string SN { get; set; }
            [JsonProperty("start_date")]
            public string StartDate { get; set; }
            [JsonProperty("end_date")]
            public string EndDate { get; set; }
            [JsonProperty("filter_name")]
            public int FilterName { get; set; }
            [JsonProperty("filter_birth")]
            public int FilterDoB { get; set; }
            [JsonProperty("filter_postno")]
            public int FilterPostNo { get; set; }
            [JsonProperty("filter_email")]
            public int FilterEmail { get; set; }
            [JsonProperty("filter_sn")]
            public int FilterSN { get; set; }
        }

        [Serializable]
        public class ExportClientResponse
        {
            public string Status { get; set; }
            [JsonProperty("error_info")]
            public ErrorInfo ErrorInfo { get; set; }
            [JsonProperty("list")]
            public List<Client> Clients { get; set; }            
            public int TotalUsers { get; set; }
        }
    }   
}
