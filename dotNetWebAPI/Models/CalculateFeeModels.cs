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
        public class LINEITEM
        {
            [DisplayName("Client Payment Type Identifier")]
            [JsonProperty(PropertyName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Item Amount")]
            [JsonProperty(PropertyName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
        }

        public class FEE
        {
            [DisplayName("Client Key")]
            [JsonProperty(PropertyName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Payment Method")]
            [JsonProperty(PropertyName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [DisplayName("Card Type")]
            [JsonProperty(PropertyName = "CARDTYPE")]
            public string CARDTYPE { get; set; }
            [DisplayName("Collection Mode")]
            [JsonProperty(PropertyName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [JsonProperty(PropertyName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Line Item")]
            [JsonProperty(PropertyName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }
    }
}