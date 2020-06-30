using AlKhalidConnector;
using AlKhalidModels;
using AlKhalidRentalsClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    [SessionExpiryFilter]
    public class PaymentController : Controller
    {
        public async Task<ActionResult> KnetResponse()
        {
            string transData = HttpContext.Request.Form["trandata"];
            PaymentResponseModel objResponse = await new PaymentUtility().AuthenticatePayment(transData);

            if (objResponse is PaymentResponseModel && !string.IsNullOrEmpty(objResponse.Result) && objResponse.Result.ToUpper() == "CAPTURED")
            {
                PaymentHistoryModel oIncomingPay = new PaymentHistoryModel();
                string CardCode = objResponse.UDF1.Split('_')[0];
                string CardName = objResponse.UDF1.Split('_')[0];
                string[] DocEntryNos = objResponse.UDF2.Split('_');
                string[] DocNumbers = objResponse.UDF3.Split('_');
                string[] TransferSums = objResponse.UDF4.Split('_');
                string[] BranchIDs = objResponse.UDF5.Split('_');
                for (int invCnt = 0; invCnt < DocEntryNos.Length; invCnt++)
                {
                    oIncomingPay.IncomingPaymentData.Add(new IncomingPayment
                    {
                        CardCode = CardCode,
                        CardName = CardName,
                        DocEntryNo = DocEntryNos[invCnt],
                        DocNumber = DocNumbers[invCnt],
                        Remarks = "KNET Payment",
                        TransferSum = double.Parse(TransferSums[invCnt]),
                        BranchID = int.Parse(BranchIDs[invCnt]),
                        TransferRefrence = objResponse.PayReference
                    });
                }
                Dictionary<string, string> paySaveRsp = await Connector.PayRentDue(oIncomingPay) as Dictionary<string, string>;
            }

            return View(@"~\Views\Rent\PayReciept.cshtml", objResponse);
        }
    }
}