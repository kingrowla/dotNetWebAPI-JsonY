using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    public class CalculateFeeModels
    {
        public class LINEITEMS
        {
            [DisplayName("Item Amount")]
            public double amount { get; set; }
            [DisplayName("Client Payment Type Identifier")]
            public string paymentType { get; set; }
        }

        public class FEE
        {
            [DisplayName("Client Key")]
            public string clientKey { get; set; }
            [DisplayName("Payment Method")]
            public int paymentMethod { get; set; }
            [DisplayName("Card Type")]
            public int cardType { get; set; }
            [DisplayName("Collection Mode")]
            public int collectionMode { get; set; }
            [DisplayName("Line Item")]
            public List<LINEITEMS> lineItems { get; set; }
        }
    }
}