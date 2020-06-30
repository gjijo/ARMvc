using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class PaymentHistoryModel
    {
        public string ErrorMessage;
        public bool isSuccess;
        public bool HasData;

        private List<IncomingPayment> IncomingPayment;
        public Dictionary<string, string> oDictionary;

        public PaymentHistoryModel()
        {
            IncomingPayment = new List<IncomingPayment>();
            oDictionary = new Dictionary<string, string>();
        }

        public List<IncomingPayment> IncomingPaymentData
        {
            get { return IncomingPayment; }
            set { IncomingPayment = value; }
        }
    }
    public class IncomingPayment
    {
        public string DocEntryNo { get; set; }
        public string DocNumber { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Remarks { get; set; }
        public double TransferSum { get; set; }
        public int BranchID { get; set; }
        public string TransferRefrence { get; set; }


    }
}
