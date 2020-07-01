using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class ResetPassword
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string NewPassword { get; set; }

    }

    public class ResetPasswordDataResponse : ConnectorResponseModel
    {
        private ResponseStatus responseStatus;
        private CompanyResult CompanyRes;
        public string ErrorMessage;
        public bool isSuccess;
        public bool HasData;
        public ResetPasswordDataResponse()
        {
            responseStatus = new ResponseStatus();
            CompanyRes = new CompanyResult();
        }
        public ResponseStatus ResponseStatus
        {
            get { return responseStatus; }
            set { responseStatus = value; }
        }
        public CompanyResult CompanyResult
        {
            get { return CompanyRes; }
            set { CompanyRes = value; }
        }
    }
}
