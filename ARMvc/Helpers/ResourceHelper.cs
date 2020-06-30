using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARMvc.Helpers
{
    public static class ResourceHelper
    {
        public static string Resource(this HtmlHelper htmlhelper, string expression)
        {
            string culture = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower();
            return LCultureHelper.GetCultureValue(culture == "en" ? "ar" : "en", expression);
        }
    }
}