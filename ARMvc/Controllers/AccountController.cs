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
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ChangePassword(ResetPassword userDetails)
        {
            UserModel objLUser = new UserModel();
               ResetPasswordDataResponse objUser = await Connector.ResetPassword(userDetails) as ResetPasswordDataResponse;
            if (objUser != null)
            {
                objLUser = await Connector.Authenticate(new UserModel() { UserName = userDetails.UserName, Password = userDetails.UserPassword }) as UserModel;
                if (objLUser != null && objLUser.IsLoggedIn)
                    Session[SessionConstants.UserSession] = objLUser;
                return Json(new ResponseModel() { Status = true, Data = objLUser, Errors = null });
            }
            return Json(new ResponseModel() { Status = true, Data = objLUser, Errors = null }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> SignIn(UserModel userDetails)
        {
            UserModel objUser = await Connector.Authenticate(userDetails) as UserModel;
            if (objUser != null && objUser.IsLoggedIn)
                Session[SessionConstants.UserSession] = objUser;
            return Json(new ResponseModel() { Status = true, Data = objUser, Errors = null }, JsonRequestBehavior.AllowGet);
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
                url = url.Replace("/ar/", "/en/");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            }
            else
            {
                url = url.Replace("/en/", "/ar/");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA");
                Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA");
            }

            CultureInfo.DefaultThreadCurrentUICulture = Thread.CurrentThread.CurrentUICulture;
            CultureInfo.DefaultThreadCurrentCulture = Thread.CurrentThread.CurrentUICulture;
            return Json(url, JsonRequestBehavior.AllowGet);
        }
    }
}