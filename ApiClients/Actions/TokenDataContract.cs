using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureTool.ApiClients
{

    public class TokenDataContract
    {
        [DataContract]
        // TOKEN発行用JSON
        public class TokenCode
        {
            [DataMember(Name = "code1")]
            public string Code1 { get; set; }
            [DataMember(Name = "code2")]
            public string Code2 { get; set; }
        }

        [DataContract]
        public class RequestResult
        {
            [DataMember(Name = "status")]
            public string Status { get; set; }
            [DataMember(Name = "error_info")]
            public List<ErrorInfo> ErrorInfos { get; set; }
            [DataMember(Name = "token")]
            public string Token { get; set; }
            [DataMember(Name = "TransactionInfo")]
            public TransactionInfo TransactionInfoData { get; set; }


            [DataContract]
            public class ErrorInfo
            {
                [DataMember(Name = "error_code")]
                public string ErrorCode { get; set; }
                [DataMember(Name = "message")]
                public string Message { get; set; }
            }

            [DataContract]
            public class TransactionInfo
            {
                [DataMember(Name = "data")]
                public string Data { get; set; }
            }
        }
    }
}
