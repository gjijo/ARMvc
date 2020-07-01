using AlKhalidModels;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AlkhalidUtility;
using System.Linq;

namespace AlKhalidConnector
{
    public class Connector
    {
        public static async Task<ConnectorResponseModel> Authenticate(UserModel user)
        {
            UserModel objUser = new UserModel();

            RentHistory objRentRsp = HttpClientRQHandler.SendRQ<RentHistory, UserModel>(user, "/GetInvoices");
            if(objRentRsp is RentHistory && objRentRsp.ResponseStatus.ResponseCode == (int)ResponseCode.Success)
            {
                objUser = new UserModel()
                {
                    UserName = user.UserName,
                    Password = user.Password,
                    CardCode = objRentRsp.Result.InvoicesData != null && objRentRsp.Result.InvoicesData.Count() > 0 ? objRentRsp.Result.InvoicesData.First().CardCode : string.Empty,
                    CardName = objRentRsp.Result.InvoicesData != null && objRentRsp.Result.InvoicesData.Count() > 0 ? objRentRsp.Result.InvoicesData.First().CardName : string.Empty,
                    IsLoggedIn = true
                };
            }

            return await Task.FromResult(objUser);
        }


        public static async Task<ConnectorResponseModel> ResetPassword(ResetPassword user)
        {
            ResetPasswordDataResponse objRPasswordR = HttpClientRQHandler.SendRQ<ResetPasswordDataResponse, ResetPassword>(user, "/ResetPassword");
            if (!(objRPasswordR is ResetPasswordDataResponse && objRPasswordR.ResponseStatus.ResponseCode == (int)ResponseCode.Success))
            {
                objRPasswordR = null;
            }
            return await Task.FromResult(objRPasswordR);
        }

        public static async Task<ConnectorResponseModel> GetRentHistory(UserModel user)
        {
            RentHistory objRentH = HttpClientRQHandler.SendRQ<RentHistory, UserModel>(user, "/GetPaidInvoices");
            if (!(objRentH is RentHistory && objRentH.ResponseStatus.ResponseCode == (int)ResponseCode.Success))
            {
                objRentH = null;
            }
            return await Task.FromResult(objRentH);
        }

        public static async Task<ConnectorResponseModel> GetRentDues(UserModel user)
        {
            RentHistory objRentH = HttpClientRQHandler.SendRQ<RentHistory, UserModel>(user, "/GetInvoices");
            if (!(objRentH is RentHistory && objRentH.ResponseStatus.ResponseCode == (int)ResponseCode.Success))
            {
                objRentH = null;
            }
            return await Task.FromResult(objRentH);
        }

        public static async Task<Dictionary<string, string>> PayRentDue(PaymentHistoryModel Invoices)
        {
            Dictionary<string, string> objRentRsp = HttpClientRQHandler.SendRQ<Dictionary<string, string>, PaymentHistoryModel>(Invoices, "/IncomingPayments");
            return await Task.FromResult(objRentRsp);
        }

        public static async Task<ConnectorResponseModel> MaintenanceBasicInfo(UserModel user)
        {
            return await Task.FromResult(new ConnectorResponseModel());
        }
        public static async Task<Dictionary<string, string>> RequestMaintenance(ServiceCallDataResponseResult RQ)
        {
            Dictionary<string, string> objRentRsp = HttpClientRQHandler.SendRQ<Dictionary<string, string>, ServiceCallDataResponseResult>(RQ, "/ServiceCall");
            return await Task.FromResult(objRentRsp);
        }

        public static async Task<ConnectorResponseModel> GetAnnouncements(UserModel user)
        {
            AnnouncementDataResponse objAnnouncement = HttpClientRQHandler.SendRQ<AnnouncementDataResponse, UserModel>(user, "/GetAnnouncement");
            return await Task.FromResult(objAnnouncement);
        }
    }
}
