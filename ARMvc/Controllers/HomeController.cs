using AlKhalidConnector;
using AlKhalidModels;
using AlKhalidRentalsClient.Helpers;
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
    [SessionExpiryFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Announcements()
        {
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            GetAnnouncementDataResponse objAnnouncements = await Connector.GetAnnouncements(objUser) as GetAnnouncementDataResponse;
            GetAnnouncement anDetails = objAnnouncements != null && objAnnouncements.Result != null && objAnnouncements.Result.GetAnnouncementData != null ? objAnnouncements.Result.GetAnnouncementData : new GetAnnouncement();
            return View(anDetails);
        }
    }
}