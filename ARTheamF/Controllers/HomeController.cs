using AlKhalidConnector;
using AlKhalidModels;
using ARTheamF.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARTheamF.Controllers
{
    [SessionExpiryFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Index3()
        {
            return View();
        }
        public async Task<ActionResult> Announcements()
        {
            UserModel objUser = Session[SessionConstants.UserSession] as UserModel;
            AnnouncementDataResponse objAnnouncements = await Connector.GetAnnouncements(objUser) as AnnouncementDataResponse;
            AnnouncementData anDetails = objAnnouncements != null && objAnnouncements != null && objAnnouncements.GetAnnouncementData != null ? objAnnouncements.GetAnnouncementData : new AnnouncementData();
            return View(anDetails);
        }
    }
}