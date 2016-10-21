using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dotNetWebAPI.Controllers
{

    [Authorize]
    [RoutePrefix("api/CalculateFee")]
    public class CalculateFeeController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Please use Post method to get a fee.";
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Please use Post method to get a fee.";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
    }
}
