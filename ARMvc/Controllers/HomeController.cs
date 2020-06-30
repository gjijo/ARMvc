using AlKhalidRentalsClient.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    [SessionExpiryFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ChangeCulture(string url)
        {
            if (Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName == "ar")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");
            }

            CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentUICulture;
            CultureInfo.DefaultThreadCurrentCulture = Thread.CurrentThread.CurrentUICulture;
            return Json(url, JsonRequestBehavior.AllowGet);
        }
    }
}