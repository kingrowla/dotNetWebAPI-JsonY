using dotNetWebAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebAPI.Controllers
{
    public class MagicAPIController : Controller
    {

        //private readonly RestClient _client;
        //private readonly string _url = ConfigurationManager.AppSettings["https://stage.collectorsolutions.com/magic-api/"];
        private RestClient client = new RestClient("https://stage.collectorsolutions.com/magic-api/");
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // GET: MagicAPI
        [HttpGet]
        public ActionResult CalculateFee()
        {
            return View();
        }
        // POST: MagicAPI
        [HttpPost]
        public ActionResult CalculateFee(CalculateFeeModels.FEE fee)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                var request = new RestRequest("api/fee", Method.POST) { RequestFormat = DataFormat.Json };
                request.AddBody(fee);
                IRestResponse response = client.Execute<CalculateFeeResponseModels.FEE>(request);
                //send data to partial view so it can be displayed//
                TempData["CalculateFeeResponse"] = JsonConvert.DeserializeObject<CalculateFeeResponseModels.FEE>(response.Content);
                return View();
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransactionPost(VirtualTerminalTransactionPostModels.VT_TRANSACTION transaction)
        {
            try
            {
                return View();
                ////send data to partial view so it can be displayed//
                //TempData["VTPostResponse"] = response;
                //if (response.RESPONSECODE.StartsWith("Y"))
                //{
                //    return Redirect("https://stage.collectorsolutions.com/magic-ui/VirtualTerminal/csi-live/" + response.TRANSACTIONID);
                //}
                //else
                //{
                //    return View();
                //}
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
        // GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransactionGet()
        {
            return View();
        }

        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransactionGet(VirtualTerminalTransactionGetModels.VT_TRANSACTION transaction)
        {
            try
            {
               
                //send data to partial view so it can be displayed//
                //TempData["VTGetResponse"] = response;
                //VirtualTerminal/{clientid}/{transactionid}
                return View();
            }
            catch (Exception e)
            {
                return View("Error");
            }

        }
        // GET: Process Credit
        [HttpGet]
        public ActionResult ProcessCredit()
        {
            return View();
        }
    }
}