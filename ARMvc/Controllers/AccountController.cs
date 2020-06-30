using AlKhalidConnector;
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
    }
}