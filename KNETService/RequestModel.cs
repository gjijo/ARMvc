using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KNETService
{
    [DataContract]
    public class RequestModel
    {
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public string ReffNo { get; set; }
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
        [DataMember]
        public Configuration KNETConfig { get; set; }
    }

    [DataContract]
    public class Configuration
    {
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public string AliasName { get; set; }
        [DataMember]
        public string ResponseURL { get; set; }
        [DataMember]
        public string ErrorURL { get; set; }
        [DataMember]
        public string ResourcePath { get; set; }
        [DataMember]
        public string KnetCurrency { get; set; }
    }
}
