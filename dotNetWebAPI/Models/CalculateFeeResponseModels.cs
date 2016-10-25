
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
            public double feeAmount { get; set; }
            public string status { get; set; }
            public List<Error> errors { get; set; }
        }
        public class Error
        {
            public string id { get; set; }
            public string message { get; set; }
        }
    }
}