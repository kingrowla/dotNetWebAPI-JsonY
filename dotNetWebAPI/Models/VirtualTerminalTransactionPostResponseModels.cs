using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    public class VirtualTerminalTransactionPostResponseModels
    {
        public class VT_TRANSACTION
        {
            [JsonProperty(PropertyName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [JsonProperty(PropertyName = "status")]
            public string status { get; set; }
        }
    }
}