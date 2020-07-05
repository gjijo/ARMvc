using AlKhalidConnector;
using AlKhalidModels;
using ARTheamF.Helpers;
using ARTheamF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARTheamF.Controllers
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
        public async Task<ActionResult> RetrieveClubbedInvoices(int dueInv, int paidInv, int maxCount)
        {
            List<InvoiceGeneralModel> lsClubbedInvoices = new List<InvoiceGeneralModel>();

            List<Task> lsTsk = new List<Task>();
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            List<Invoicesdata> lsDueInvoices = new List<Invoicesdata>();
            List<PaidInvoices> lsPaidInvoices = new List<PaidInvoices>();
            Task dueTask = await Task.Factory.StartNew(async () =>
            {
                RentHistory objInvoices = await Connector.GetRentDues(objUser) as RentHistory;
                if (objInvoices != null && objInvoices.Result != null && objInvoices.Result.InvoicesData != null)
                {
                    lsDueInvoices = objInvoices.Result.InvoicesData.ToList();
                }

            }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);
            Task paidTask = await Task.Factory.StartNew(async () =>
            {
                PaidRentHistory objInvoices = await Connector.GetRentHistory(objUser) as PaidRentHistory;
                if (objInvoices != null && objInvoices.Result != null && objInvoices.Result.InvoicesData != null)
                {
                    lsPaidInvoices = objInvoices.Result.InvoicesData.ToList();
                }

            }, CancellationToken.None, TaskCreationOptions.DenyChildAttach, TaskScheduler.Default);

            lsTsk.Add(dueTask);
            lsTsk.Add(paidTask);

            await Task.WhenAll(lsTsk.ToArray());

            if (lsDueInvoices is List<Invoicesdata>)
            {
                dueInv = dueInv == 0 ? lsDueInvoices.Count : lsDueInvoices.Count > dueInv ? lsDueInvoices.Count : lsDueInvoices.Count;
                for (int invCnt = 0; invCnt < lsDueInvoices.Count; invCnt++)
                {
                    lsClubbedInvoices.Add(new InvoiceGeneralModel()
                    {
                        BranchID = "",
                        DocEntryNo = lsDueInvoices[invCnt].DocEntryNo,
                        InvoiceMonth = lsDueInvoices[invCnt].strDocMonth,
                        DocTotal = lsDueInvoices[invCnt].DocTotal,
                        InvoiceCurrency = "KWD",
                        InvoiceDate = lsDueInvoices[invCnt].strDocDate,
                        InvoiceDueDate = lsDueInvoices[invCnt].strDueDate,
                        InvoiceFine = "0",
                        IsPaid = false
                    });
                }
            }
            if (lsPaidInvoices is List<PaidInvoices>)
            {
                paidInv = paidInv == 0 ? lsPaidInvoices.Count : lsPaidInvoices.Count > paidInv ? lsPaidInvoices.Count : lsPaidInvoices.Count;
                for (int invCnt = 0; invCnt < lsPaidInvoices.Count; invCnt++)
                {
                    lsClubbedInvoices.Add(new InvoiceGeneralModel()
                    {
                        BranchID = "",
                        DocEntryNo = lsPaidInvoices[invCnt].IPDocNum,
                        InvoiceMonth = lsPaidInvoices[invCnt].strDocMonth,
                        DocTotal = lsPaidInvoices[invCnt].InvPaidAmount.ToString(),
                        InvoiceCurrency = "KWD",
                        InvoiceDate = lsPaidInvoices[invCnt].strDocDate,
                        InvoiceFine = "0",
                        IsPaid = true,
                        Payment = new InvoicePayment()
                        {
                            InvReffNo = lsPaidInvoices[invCnt].PayRefNo,
                            PayID = lsPaidInvoices[invCnt].PayID,
                            PayReff = lsPaidInvoices[invCnt].RefNo
                        }
                    });
                }
            }

            maxCount = maxCount == 0 ? lsClubbedInvoices.Count : maxCount;

            return Json(new ResponseModel() { Status = false, Data = lsClubbedInvoices.Take(maxCount), Errors = null }, JsonRequestBehavior.AllowGet);
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
            PaidRentHistory objInvoices = await Connector.GetRentHistory(objUser) as PaidRentHistory;
            List<PaidInvoices> lsInvoices = new List<PaidInvoices>();
            if (objInvoices != null && objInvoices.Result != null && objInvoices.Result.InvoicesData != null)
            {
                lsInvoices = objInvoices.Result.InvoicesData.ToList();
            }
            return Json(new ResponseModel() { Status = false, Data = lsInvoices, Errors = null }, JsonRequestBehavior.AllowGet);
        }
    }
}