using AlKhalidModels;
using AlKhalidRentalsClient.Helpers;
using ARMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    [SessionExpiryFilter]
    public class RentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> PayRent(PaymentRequestModel RQ)
        {
            PaymentResponseModel objResponse = await new PaymentUtility().InitiatePayment(RQ);
            if (objResponse is PaymentResponseModel && string.IsNullOrEmpty(objResponse.ErrorMessage))
            {
                Response.Redirect(objResponse.RedirectionURL);
            }
            return Json(new ResponseModel() { Status = false, Data = objResponse, Errors = new List<string> { "Payment Error" } });
        }

        public ActionResult PayReciept(PaymentResponseModel RQ)
        {
            return View(RQ);
        }

        public ActionResult History()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> RetrieveHistoricData()
        {
            return Json(new ResponseModel() { Status = false, Data = null, Errors = null });
        }
    }
}