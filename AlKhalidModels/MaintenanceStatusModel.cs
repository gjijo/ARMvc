using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class ServiceCallDataResponseResult
    {
        public string ErrorMessage;
        public bool isSuccess;
        public bool HasData;
        public string ReturnNumber;

        private List<ServiceCall> ServiceCall;

        public ServiceCallDataResponseResult()
        {
            ServiceCall = new List<ServiceCall>();
        }
        public List<ServiceCall> ServiceCallData
        {
            get { return ServiceCall; }
            set { ServiceCall = value; }
        }
    }
    public class ServiceCall
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Subject { get; set; }
    }
}
