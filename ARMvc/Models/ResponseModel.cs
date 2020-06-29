using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARMvc.Models
{
    public class ResponseModel
    {
        public bool Status { get; set; }
        public object Data { get; set; }
        public List<String> Errors { get; set; }
    }
}
