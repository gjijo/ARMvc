using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KNETService
{
    public class KNETService : IKNETService
    {
        public ResponseModel InitPayment(RequestModel objRequest)
        {
            KnetInitializer _objKNET = KnetInitializer.GetInstance(objRequest.KNETConfig);
            ResponseModel objResponse = new ResponseModel();
            string payAmount = String.Format("{0:0.000}", objRequest.Amount);

            com.fss.plugin.iPayPipe pipe = new com.fss.plugin.iPayPipe();
            pipe.setTrackId((new Random().Next(10000000) + 1) + objRequest.ReffNo);
            pipe.setAlias(_objKNET.AliasName);
            pipe.setResourcePath(_objKNET.ResourcePath);
            pipe.setLanguage(_objKNET.Language);
            pipe.setAction("1");
            pipe.setAmt(payAmount);
            pipe.setCurrency("414");
            pipe.setUdf1(objRequest.UDF1);
            pipe.setUdf2(objRequest.UDF2);
            pipe.setUdf3(objRequest.UDF3);
            pipe.setUdf4(objRequest.UDF4);
            pipe.setUdf5(objRequest.UDF5);
            pipe.setKeystorePath(_objKNET.ResourcePath);
            pipe.setResponseURL(_objKNET.ResponseURL);
            pipe.setErrorURL(_objKNET.ErrorURL); 
            int transVal = System.Convert.ToInt16(pipe.performPaymentInitializationHTTP());
            if (transVal == 0) /* Success case */
                objResponse.RedirectionURL = pipe.getWebAddress();
            else  /* Failure case */
                objResponse.ErrorMessage = pipe.getError();
            objResponse.PayReference = pipe.getTrackId();

            StringBuilder _strb = new StringBuilder();
            _strb.Append("");

            return objResponse;
        }
        public ResponseModel RetrievePaymentData(RequestModel objRequest, string transData)
        {
            ResponseModel objResponse = new ResponseModel();
            KnetInitializer _objKNET = KnetInitializer.GetInstance(objRequest.KNETConfig);
            com.fss.plugin.iPayPipe pipe = new com.fss.plugin.iPayPipe();
            string trandata = transData ?? string.Empty;
            pipe.setResourcePath(_objKNET.ResourcePath);
            pipe.setKeystorePath(_objKNET.ResourcePath);
            pipe.setAlias(_objKNET.AliasName);
            int parseResult = pipe.parseEncryptedRequest(trandata);

            objResponse.PaymentId = pipe.getPaymentId();
            objResponse.Result = pipe.getResult();
            objResponse.Date = pipe.getDate();
            objResponse.TransID = pipe.getTransId();
            objResponse.Auth = pipe.getAuth();
            objResponse.Reference = pipe.getRef();
            objResponse.PayReference = pipe.getTrackId();
            objResponse.UDF1 = pipe.getUdf1();
            objResponse.UDF2 = pipe.getUdf2();
            objResponse.UDF3 = pipe.getUdf3();
            objResponse.UDF4 = pipe.getUdf4();
            objResponse.UDF5 = pipe.getUdf5();
            objResponse.ErrorMessage = pipe.getError();

            return objResponse;
        }
    }
}
