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
            return View(objResponse);
        }
    }
}