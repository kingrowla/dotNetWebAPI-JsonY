using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    [Serializable()]
    public class VirtualTerminalTransactionGetResponseModels
    {
        public class Error
        {
            public string id { get; set; }
            public string message { get; set; }
        }

        public class VT_TRANSACTION
        {
            public string transactionIdentifier { get; set; }
            public int approvalStatus { get; set; }
            public int paymentReceiptConfirmation { get; set; }
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime dateTime { get; set; }
            public string name { get; set; }
            public int paymentMethod { get; set; }
            public int cardType { get; set; }
            public string cardNumberMasked { get; set; }
            public string accountNumberLast4 { get; set; }
            [DisplayFormat(DataFormatString = "{0:C0}")]
            public decimal amount { get; set; }
            [DisplayFormat(DataFormatString = "{0:C0}")]
            public decimal feeAmount { get; set; }
            [DisplayFormat(DataFormatString = "{0:C0}")]
            public decimal totalRemitted { get; set; }
            public string status { get; set; }
            public List<Error> errors { get; set; }
        }
    }
}