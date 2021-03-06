﻿using AlKhalidConnector;
using AlKhalidModels;
using AlKhalidRentalsClient.Helpers;
using ARMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            RQ.UDF1 = objUser.CardCode + "_" + objUser.CardName;
            RQ.Culture = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            PaymentResponseModel objResponse = await new PaymentUtility().InitiatePayment(RQ);
            if (objResponse is PaymentResponseModel && string.IsNullOrEmpty(objResponse.ErrorMessage))
            {
                Response.Redirect(objResponse.RedirectionURL);
            }
            return View(@"~\Views\Rent\PayReciept.cshtml", objResponse);
        }

        public ActionResult History()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> RetrieveDueInvoices()
        {
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            RentHistory objInvoices = await Connector.GetRentDues(objUser) as RentHistory;
            List<Invoicesdata> lsInvoices = new List<Invoicesdata>();
            if (objInvoices != null && objInvoices.Result != null && objInvoices.Result.InvoicesData != null)
            {
                lsInvoices = objInvoices.Result.InvoicesData.ToList();
            }
            return Json(new ResponseModel() { Status = false, Data = lsInvoices, Errors = null }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public async Task<ActionResult> RetrieveHistoricInvoices()
        {
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            RentHistory objInvoices = await Connector.GetRentHistory(objUser) as RentHistory;
            List<Invoicesdata> lsInvoices = new List<Invoicesdata>();
            if (objInvoices != null && objInvoices.Result != null && objInvoices.Result.InvoicesData != null)
            {
                lsInvoices = objInvoices.Result.InvoicesData.ToList();
            }
            return Json(new ResponseModel() { Status = false, Data = lsInvoices, Errors = null }, JsonRequestBehavior.AllowGet);
        }
    }
}