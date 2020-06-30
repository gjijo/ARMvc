using AlKhalidConnector;
using AlKhalidModels;
using AlKhalidRentalsClient.Helpers;
using ARMvc.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> SignIn(UserModel userDetails)
        {
            UserModel objUser = await Connector.Authenticate(userDetails) as UserModel;
            Session[SessionConstants.UserSession] = objUser;
            return Json(new ResponseModel() { Status = true, Data = objUser, Errors = null });
        }

        [HttpGet]
        public async Task<ActionResult> SignOut()
        {
            HttpContext.Session.Remove(SessionConstants.UserSession);
            return RedirectToAction("Index");
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