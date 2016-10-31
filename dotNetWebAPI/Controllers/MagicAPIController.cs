using dotNetWebAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace dotNetWebAPI.Controllers
{
    public class MagicAPIController : Controller
    {
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
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;//Needed for .net4.5 and below
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
        // GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransactionPost()
        {
            return View();
        }
        // POST: VirtualTerminalTransaction
        [HttpPost]
        public ActionResult VirtualTerminalTransactionPost(VirtualTerminalTransactionPostModels.VT_TRANSACTION transaction)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;//Needed for .net4.5 and below
                //add any additional objects to model//for demo purposes we set them static//
                transaction.COLLECTIONMODE = "1";
                transaction.CSIUSERID = "1";
                transaction.URLSILENTPOST = "";
                transaction.PHONE = Regex.Replace(transaction.PHONE, @"\D", "");
                var request = new RestRequest("api/transaction/redirect", Method.POST) { RequestFormat = DataFormat.Json };
                request.AddBody(transaction);
                IRestResponse response = client.Execute<VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION>(request);
                //send data to partial view so it can be displayed//
                var vtResponse = JsonConvert.DeserializeObject<VirtualTerminalTransactionPostResponseModels.VT_TRANSACTION>(response.Content);
                TempData["VTPostResponse"] = vtResponse;
                if (vtResponse.status == "ok")
                {
                    return Redirect("https://stage.collectorsolutions.com/magic-ui/VirtualTerminal/csi-live/" + vtResponse.TRANSACTIONID);
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        //// GET: VirtualTerminalTransaction
        [HttpGet]
        public ActionResult VirtualTerminalTransactionGet(VirtualTerminalTransactionGetResponseModels.VT_TRANSACTION transaction)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;//Needed for .net4.5 and below
                //https://stage.collectorsolutions.com/magic-api/api/transaction/{clientKey}/{transactionId}
                var request = new RestRequest("api/transaction/8E3F20CE5619431D9BE737FD80E3E990/fa743adff96e530965cae46ce4fd", Method.GET) { RequestFormat = DataFormat.Json };
                IRestResponse response = client.Execute<VirtualTerminalTransactionGetResponseModels.VT_TRANSACTION>(request);
                ////send data to partial view so it can be displayed//
                transaction = JsonConvert.DeserializeObject<VirtualTerminalTransactionGetResponseModels.VT_TRANSACTION>(response.Content);
                return View(transaction);
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