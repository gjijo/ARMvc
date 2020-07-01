using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AlKhalidModels
{
    public class RentHistory : ConnectorResponseModel
    {
        public CompanyResult CompanyResult { get; set; }
        public ResponseStatus ResponseStatus { get; set; }
        public Result Result { get; set; }
    }

    public class CompanyResult
    {
        public object Exception { get; set; }
        public object _Connection { get; set; }
        public bool isConnected { get; set; }
    }

    public class ResponseStatus
    {
        public int ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string ResponseTitle { get; set; }
    }

    public class Result
    {
        public object ErrorMessage { get; set; }
        public bool HasData { get; set; }
        public Invoicesdata[] InvoicesData { get; set; }
        public bool isSuccess { get; set; }
    }

    public class Invoicesdata
    {
        public string Address { get; set; }
        public int BranchID { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string strDocDate { get { return DocDate.ToString("dd/MM/yyyy", new CultureInfo("en-US")); } }
        public string strDocMonth { get { return DocDate.ToString("MMMM", new CultureInfo("en-US")); } }
        public DateTime DocDate { get; set; }
        public string DocEntryNo { get; set; }
        public string DocNumber { get; set; }
        public string DocStatus { get; set; }
        public string DocTotal { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DueDate { get; set; }
        public string strDueDate { get { return DueDate.ToString("dd/MM/yyyy", new CultureInfo("en-US")); } }
        public string strDueMonth { get { return DueDate.ToString("MMMM", new CultureInfo("en-US")); } }
    }
}




