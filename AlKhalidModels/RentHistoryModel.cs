using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class RentHistory : ConnectorResponseModel
    {
        public Companyresult CompanyResult { get; set; }
        public Responsestatus ResponseStatus { get; set; }
        public Result Result { get; set; }
    }

    public class Companyresult
    {
        public object Exception { get; set; }
        public object _Connection { get; set; }
        public bool isConnected { get; set; }
    }

    public class Responsestatus
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
        public string strDocDate { get { return DocDate.ToString("dd/MM/yyyy"); } }
        public DateTime DocDate { get; set; }
        public string DocEntryNo { get; set; }
        public string DocNumber { get; set; }
        public string DocStatus { get; set; }
        public string DocTotal { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DueDate { get; set; }
        public string strDueDate { get { return DueDate.ToString("dd/MM/yyyy"); } }
    }
}




