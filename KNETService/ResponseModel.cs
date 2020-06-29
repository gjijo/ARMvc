using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KNETService
{
    [DataContract]
    public class ResponseModel
    {
        [DataMember]
        public string RedirectionURL { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string PayReference { get; set; }
        [DataMember]
        public string PaymentId { get; set; }
        [DataMember]
        public string Result { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string TransID { get; set; }
        [DataMember]
        public string Auth { get; set; }
        [DataMember]
        public string Reference { get; set; }
        [DataMember]
        public string UDF1 { get; set; }
        [DataMember]
        public string UDF2 { get; set; }
        [DataMember]
        public string UDF3 { get; set; }
        [DataMember]
        public string UDF4 { get; set; }
        [DataMember]
        public string UDF5 { get; set; }
    }
}
