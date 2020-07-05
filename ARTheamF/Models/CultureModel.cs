using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARMvc.Models
{
    public class CultureModel
    {
        public string Culture { get; set; }
        public IDictionary<string, string> CultureItem { get; set; }
    }
}