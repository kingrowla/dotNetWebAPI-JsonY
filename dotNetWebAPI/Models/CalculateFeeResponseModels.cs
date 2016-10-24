
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dotNetWebAPI.Models
{
    [Serializable()]
    public class CalculateFeeResponseModels
    {
        public class FEE
        {
            [DisplayName("Fee Amount")]
            [JsonProperty(PropertyName = "FEEAMOUNT")]
            public string FEEAMOUNT { get; set; }
            [DisplayName("Response Code")]
            [JsonProperty(PropertyName = "RESPONSECODE")]
            public string RESPONSECODE { get; set; }
        }
    }
}