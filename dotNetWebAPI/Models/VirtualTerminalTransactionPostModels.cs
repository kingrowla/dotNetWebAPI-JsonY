using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    public class VirtualTerminalTransactionPostModels
    {
        public class LINEITEM
        {
            [DisplayName("Account")]
            [JsonProperty(PropertyName = "PAYMENTID")]
            public string PAYMENTID { get; set; }
            [DisplayName("Account Secondary")]
            [JsonProperty(PropertyName = "PAYMENTID_SECONDARY")]
            public string PAYMENTID_SECONDARY { get; set; }
            [DisplayName("Line Item Amount")]
            [JsonProperty(PropertyName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
            [DisplayName("Customer Payment Type Identifier")]
            [JsonProperty(PropertyName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [DisplayName("Miscellaneous One")]
            [JsonProperty(PropertyName = "MISC_ONE")]
            public string MISC_ONE { get; set; }
            [DisplayName("Miscellaneous Two")]
            [JsonProperty(PropertyName = "MISC_TWO")]
            public string MISC_TWO { get; set; }
            [JsonProperty(PropertyName = "MISC_THREE")]
            [DisplayName("Miscellaneous Three")]
            public string MISC_THREE { get; set; }
            [JsonProperty(PropertyName = "MISC_FOUR")]
            public string MISC_FOUR { get; set; }
            [JsonProperty(PropertyName = "MISC_FIVE")]
            public string MISC_FIVE { get; set; }
            [JsonProperty(PropertyName = "MISC_SIX")]
            public string MISC_SIX { get; set; }
            [JsonProperty(PropertyName = "MISC_SEVEN")]
            public string MISC_SEVEN { get; set; }
            [JsonProperty(PropertyName = "MISC_EIGHT")]
            public string MISC_EIGHT { get; set; }
            [JsonProperty(PropertyName = "MISC_NINE")]
            public string MISC_NINE { get; set; }
            [JsonProperty(PropertyName = "MISC_TEN")]
            public string MISC_TEN { get; set; }
            [JsonProperty(PropertyName = "MISC_ELEVEN")]
            public string MISC_ELEVEN { get; set; }
            [JsonProperty(PropertyName = "MISC_TWELVE")]
            public string MISC_TWELVE { get; set; }
            [JsonProperty(PropertyName = "MISC_THIRTEEN")]
            public string MISC_THIRTEEN { get; set; }
            [JsonProperty(PropertyName = "MISC_FOURTEEN")]
            public string MISC_FOURTEEN { get; set; }
            [JsonProperty(PropertyName = "MISC_FIFTEEN")]
            public string MISC_FIFTEEN { get; set; }
        }

        public class VT_TRANSACTION
        {
            [DisplayName("Client Key"), Description("herror")]
            [JsonProperty(PropertyName = "CLIENTKEY")]
            public string CLIENTKEY { get; set; }
            [DisplayName("Transaction Identifier")]
            [JsonProperty(PropertyName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [DisplayName("Collection Mode")]
            [JsonProperty(PropertyName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [DisplayName("Amount")]
            [JsonProperty(PropertyName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [DisplayName("Name")]
            [JsonProperty(PropertyName = "NAME")]
            public string NAME { get; set; }
            [DisplayName("Address")]
            [JsonProperty(PropertyName = "ADDRESS")]
            public string ADDRESS { get; set; }
            [DisplayName("Address Two")]
            [JsonProperty(PropertyName = "ADDRESSTWO")]
            public string ADDRESSTWO { get; set; }
            [DisplayName("City")]
            [JsonProperty(PropertyName = "CITY")]
            public string CITY { get; set; }
            [DisplayName("County")]
            [JsonProperty(PropertyName = "COUNTY")]
            public string COUNTY { get; set; }
            [DisplayName("State")]
            [RegularExpression("[A-Z]{2}")]
            [JsonProperty(PropertyName = "STATE")]
            public string STATE { get; set; }
            [DisplayName("Country")]
            [JsonProperty(PropertyName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [DisplayName("Zip Code")]
            [JsonProperty(PropertyName = "ZIP")]
            public string ZIP { get; set; }
            [DisplayName("Email Address")]
            [JsonProperty(PropertyName = "EMAIL")]
            public string EMAIL { get; set; }
            [DisplayName("Mobile Number")]
            [JsonProperty(PropertyName = "PHONE")]
            public string PHONE { get; set; }
            [DisplayName("Notes")]
            [JsonProperty(PropertyName = "NOTES")]
            public string NOTES { get; set; }
            [DisplayName("CSI User Identifier")]
            [JsonProperty(PropertyName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
            [JsonProperty(PropertyName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
            [DisplayName("URL Silent Post")]
            [JsonProperty(PropertyName = "URLSILENTPOST")]
            public string URLSILENTPOST { get; set; }
            [JsonProperty(PropertyName = "URLRETURNPOST")]
            public string URLRETURNPOST { get; set; }
            [JsonProperty(PropertyName = "ALLOWEDPAYMENTMETHOD")]
            public string ALLOWEDPAYMENTMETHOD { get; set; }
        }
    }
}