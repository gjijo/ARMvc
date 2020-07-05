using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class PaidRentHistory : ConnectorResponseModel
    {
        private ResponseStatus responseStatus;
        private PaidInvoicesResponseResult result;
        private CompanyResult CompanyRes;

        public PaidRentHistory()
        {
            responseStatus = new ResponseStatus();
            result = new PaidInvoicesResponseResult();
            CompanyRes = new CompanyResult();
        }
        public ResponseStatus ResponseStatus
        {
            get { return responseStatus; }
            set { responseStatus = value; }
        }
        public PaidInvoicesResponseResult Result
        {
            get { return result; }
            set { result = value; }

        }
        public CompanyResult CompanyResult
        {
            get { return CompanyRes; }
            set { CompanyRes = value; }
        }
    }

    public class PaidInvoicesResponseResult
    {

        public string ErrorMessage;
        public bool isSuccess;
        public bool HasData;

        private List<PaidInvoices> Invoices;

        public PaidInvoicesResponseResult()
        {
            Invoices = new List<PaidInvoices>();
        }
        public List<PaidInvoices> InvoicesData
        {
            get { return Invoices; }
            set { Invoices = value; }
        }
    }

    public class PaidInvoices
    {
        public string IPDocNum { get; set; }
        public DateTime IPDocDate { get; set; }
        public string CardCode { get; set; }
        public double PaidAmount { get; set; }
        public string ARDocNum { get; set; }
        public string PayStatus { get; set; }
        public string InvStatus { get; set; }
        public double InvPaidAmount { get; set; }
        public string PayRefNo { get; set; }
        public string PayID { get; set; }
        public string RefNo { get; set; }

        public string strDocMonth { get { return IPDocDate.ToString("MMMM", new CultureInfo("en-US")); } }
        public string strDocDate { get { return IPDocDate.ToString("dd/MM/yyyy", new CultureInfo("en-US")); } }
    }
}
