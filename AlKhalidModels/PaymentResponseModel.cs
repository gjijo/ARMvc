using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class PaymentResponseModel
    {
        public string RedirectionURL { get; set; }
        public string ErrorMessage { get; set; }
        public string PayReference { get; set; }
        public string PaymentId { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
        public string TransID { get; set; }
        public string Auth { get; set; }
        public string Reference { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
    }
}
