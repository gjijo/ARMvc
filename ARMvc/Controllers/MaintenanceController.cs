﻿using AlKhalidConnector;
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
    public class MaintenanceController : Controller
    {
        public ActionResult Index()
        {
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            MaintenanceModel RQ = new MaintenanceModel()
            {
                CardCode = objUser.CardCode,
                CardName = objUser.CardName
            };
            return View(RQ);
        }

        [HttpGet]
        public async Task<ActionResult> PreviousMainatenanceStatus()
        {
            return Json(new ResponseModel() { Status = false, Data = null, Errors = null });
        }

        [HttpPost]
        public async Task<ActionResult> RequestService(MaintenanceModel RQ)
        {
            ServiceCallDataResponseResult oServiceCall = new ServiceCallDataResponseResult();
            oServiceCall.ServiceCallData.Add(new ServiceCall
            {
                CardCode = RQ.CardCode,
                CardName = RQ.CardName,
                Subject = RQ.Subject
            });

            Dictionary<string, string> objResponse = await Connector.RequestMaintenance(oServiceCall) as Dictionary<string, string>;

            if (objResponse is Dictionary<string, string> && objResponse.ContainsKey("ErrorMessage") && !string.IsNullOrEmpty(objResponse["ErrorMessage"]))
            {
                RQ.IsRequested = false;
            }
            if (objResponse is Dictionary<string, string> && objResponse.ContainsKey("ReturnNumber") && !string.IsNullOrEmpty(objResponse["ReturnNumber"]))
            {
                RQ.IsRequested = true;
                RQ.RequestReffNo = objResponse["ReturnNumber"];
            }
            return View(@"~\Views\Maintenance\MaintenanceSummary.cshtml", objResponse);
        }
    }
}