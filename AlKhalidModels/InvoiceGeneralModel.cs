using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class InvoiceGeneralModel
    {
        public string DocEntryNo { get; set; }
        public string DocNumber { get; set; }
        public string InvoiceMonth { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceDueDate { get; set; }
        public string DocTotal { get; set; }
        public string BranchID { get; set; }
        public string InvoiceFine { get; set; }
        public string InvoiceCurrency { get; set; }
        public bool IsPaid { get; set; }
        public InvoicePayment Payment { get; set; }
    }
    public class InvoicePayment
    {
        public string PayReff { get; set; }
        public string PayID { get; set; }
        public string InvReffNo { get; set; }
    }
}
