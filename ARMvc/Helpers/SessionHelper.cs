﻿using AlKhalidRentalsClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Helpers
{
    public class SessionHelper
    {
        public static bool IsLoggedInUser
        {
            get
            {
                return HttpContext.Current.Session[SessionConstants.UserSession] == null;
            }
        }
    }
}