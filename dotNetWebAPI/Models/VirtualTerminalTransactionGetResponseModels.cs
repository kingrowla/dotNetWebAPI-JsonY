using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dotNetWebAPI.Models
{
    public class VirtualTerminalTransactionGetResponseModels
    {
        public class LINEITEM
        {
            [JsonProperty(PropertyName = "CUSTOMERPAYMENTTYPEID")]
            public string CUSTOMERPAYMENTTYPEID { get; set; }
            [JsonProperty(PropertyName = "PAYMENTID")]
            public string PAYMENTID { get; set; }
            [JsonProperty(PropertyName = "PAYMENTIDSECONDARY")]
            public string PAYMENTIDSECONDARY { get; set; }
            [JsonProperty(PropertyName = "ITEMAMOUNT")]
            public string ITEMAMOUNT { get; set; }
            [JsonProperty(PropertyName = "MISC_ONE")]
            public string MISC_ONE { get; set; }
            [JsonProperty(PropertyName = "MISC_TWO")]
            public string MISC_TWO { get; set; }
            [JsonProperty(PropertyName = "MISC_THREE")]
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
            [JsonProperty(PropertyName = "TRANSACTIONID")]
            public string TRANSACTIONID { get; set; }
            [JsonProperty(PropertyName = "COUNT")]
            public string COUNT { get; set; }
            [JsonProperty(PropertyName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
            [JsonProperty(PropertyName = "APPROVALSTATUS")]
            public string APPROVALSTATUS { get; set; }
            [JsonProperty(PropertyName = "PRC")]
            public string PRC { get; set; }
            [JsonProperty(PropertyName = "EFFECTIVEDATE")]
            public string EFFECTIVEDATE { get; set; }
            [JsonProperty(PropertyName = "DATENOW")]
            public string DATENOW { get; set; }
            [JsonProperty(PropertyName = "TIMENOW")]
            public string TIMENOW { get; set; }
            [JsonProperty(PropertyName = "NAME")]
            public string NAME { get; set; }
            [JsonProperty(PropertyName = "ADDRESS")]
            public string ADDRESS { get; set; }
            [JsonProperty(PropertyName = "ADDRESSTWO")]
            public string ADDRESSTWO { get; set; }
            [JsonProperty(PropertyName = "CITY")]
            public string CITY { get; set; }
            [JsonProperty(PropertyName = "COUNTY")]
            public string COUNTY { get; set; }
            [JsonProperty(PropertyName = "STATE")]
            public string STATE { get; set; }
            [JsonProperty(PropertyName = "ZIP")]
            public string ZIP { get; set; }
            [JsonProperty(PropertyName = "COUNTRY")]
            public string COUNTRY { get; set; }
            [JsonProperty(PropertyName = "PHONE")]
            public string PHONE { get; set; }
            [JsonProperty(PropertyName = "EMAIL")]
            public string EMAIL { get; set; }
            [JsonProperty(PropertyName = "NOTES")]
            public string NOTES { get; set; }
            [JsonProperty(PropertyName = "PAYMENTMETHOD")]
            public string PAYMENTMETHOD { get; set; }
            [JsonProperty(PropertyName = "CREDITCARDNUMBER")]
            public string CREDITCARDNUMBER { get; set; }
            [JsonProperty(PropertyName = "BANKNAME")]
            public string BANKNAME { get; set; }
            [JsonProperty(PropertyName = "CHECKNUMBER")]
            public string CHECKNUMBER { get; set; }
            [JsonProperty(PropertyName = "ROUTINGNUMBER")]
            public string ROUTINGNUMBER { get; set; }
            [JsonProperty(PropertyName = "ACCOUNTNUMBER")]
            public string ACCOUNTNUMBER { get; set; }
            [JsonProperty(PropertyName = "CSIUSERID")]
            public string CSIUSERID { get; set; }
            [JsonProperty(PropertyName = "COLLECTIONMODE")]
            public string COLLECTIONMODE { get; set; }
            [JsonProperty(PropertyName = "AMOUNT")]
            public string AMOUNT { get; set; }
            [JsonProperty(PropertyName = "FEEAMOUNT")]
            public string FEEAMOUNT { get; set; }
            [JsonProperty(PropertyName = "TOTALREMITTED")]
            public string TOTALREMITTED { get; set; }
            [JsonProperty(PropertyName = "LINEITEM")]
            public LINEITEM LINEITEM { get; set; }
        }
    }
}