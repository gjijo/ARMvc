using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class PaymentRequestModel
    {
        public double Amount { get; set; }
        public string ReffNo { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string UDF4 { get; set; }
        public string UDF5 { get; set; }
        public string Culture { get; set; }
    }
}
