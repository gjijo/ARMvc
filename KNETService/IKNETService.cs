using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KNETService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKNETService
    {
        [OperationContract]
        ResponseModel InitPayment(RequestModel objRequest);

        [OperationContract]
        ResponseModel RetrievePaymentData(RequestModel objRequest, string transData);
    }
}
