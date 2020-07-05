using AlKhalidModels;
using AlkhalidUtility;
using ARTheamF.Helpers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARTheamF.Helpers
{
    public class PaymentUtility
    {
        public async Task<PaymentResponseModel> InitiatePayment(PaymentRequestModel payModel)
        {
            PaymentResponseModel dtoPayResponse = new PaymentResponseModel();
            try
            {
                ARTheamF.KnetService.RequestModel objRequest = new ARTheamF.KnetService.RequestModel()
                {
                    Amount = payModel.Amount,
                    ReffNo = payModel.ReffNo,
                    UDF1 = payModel.UDF1,
                    UDF2 = payModel.UDF2,
                    UDF3 = payModel.UDF3,
                    UDF4 = payModel.UDF4,
                    UDF5 = payModel.UDF5,
                    KNETConfig = new ARTheamF.KnetService.Configuration()
                    {
                        Language = ConfigSettings.KnetLanguage,
                        AliasName = ConfigSettings.KnetAliasName,
                        ResponseURL = string.Format(ConfigSettings.KnetResponseURL, payModel.Culture),
                        ErrorURL = string.Format(ConfigSettings.KnetErrorURL),
                        ResourcePath = ConfigSettings.KnetResourcePath,
                        KnetCurrency = ConfigSettings.KnetCurrency
                    }
                };
                ARTheamF.KnetService.ResponseModel objResponse = await new ARTheamF.KnetService.KNETServiceClient().InitPaymentAsync(objRequest);
                dtoPayResponse = ObjectAutoMap.Map<ARTheamF.KnetService.ResponseModel, PaymentResponseModel>(objResponse);
            }
            catch (Exception ex)
            {
                dtoPayResponse = ObjectAutoMap.Map<PaymentRequestModel, PaymentResponseModel>(payModel);
                dtoPayResponse.ErrorMessage = "Payment service is down. Please try again later";
            }
            return dtoPayResponse;
        }

        public async Task<PaymentResponseModel> AuthenticatePayment(string transData)
        {
            ARTheamF.KnetService.RequestModel objRequest = new ARTheamF.KnetService.RequestModel()
            {
                KNETConfig = new ARTheamF.KnetService.Configuration()
                {
                    Language = ConfigSettings.KnetLanguage,
                    AliasName = ConfigSettings.KnetAliasName,
                    ResponseURL = ConfigSettings.KnetResponseURL,
                    ErrorURL = ConfigSettings.KnetErrorURL,
                    ResourcePath = ConfigSettings.KnetResourcePath,
                    KnetCurrency = ConfigSettings.KnetCurrency
                }
            };
            ARTheamF.KnetService.ResponseModel objResponse = await new ARTheamF.KnetService.KNETServiceClient().RetrievePaymentDataAsync(objRequest, transData);
            var dtoPayResponse = ObjectAutoMap.Map<ARTheamF.KnetService.ResponseModel, PaymentResponseModel>(objResponse);
            return dtoPayResponse;
        }
    }
}
