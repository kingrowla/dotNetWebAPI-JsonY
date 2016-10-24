using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    public class VirtualTerminalTransactionGetModels
    {
        public class VT_TRANSACTION
        {
            public string CLIENTKEY { get; set; }
            public string TRANSACTIONID { get; set; }
        }
    }
}