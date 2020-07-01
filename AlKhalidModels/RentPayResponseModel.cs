using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class RentPayResponseModel : ConnectorResponseModel
    {
        public object ErrorMessage { get; set; }
        public bool HasData { get; set; }
        public Incomingpaymentdata[] IncomingPaymentData { get; set; }
        public bool isSuccess { get; set; }
        public IDictionary<string, string> oDictionary { get; set; }
    }

    public class Incomingpaymentdata
    {
        public int BranchID { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string DocEntryNo { get; set; }
        public string DocNumber { get; set; }
        public string Remarks { get; set; }
        public object TransferRefrence { get; set; }
        public int TransferSum { get; set; }
    }
}
