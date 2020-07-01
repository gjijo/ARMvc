using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class ServiceReponse : ConnectorResponseModel
    {
        public object ErrorMessage { get; set; }
        public bool HasData { get; set; }
        public string ReturnNumber { get; set; }
        public ServiceCallData[] ServiceCallData { get; set; }
        public bool isSuccess { get; set; }
    }

    public class ServiceCallData
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Subject { get; set; }
    }

}
