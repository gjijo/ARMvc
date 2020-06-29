using AlKhalidModels;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AlKhalidConnector
{
    public class Connector
    {
        public static async Task<ConnectorResponseModel> Authenticate(UserModel user)
        {
            UserModel objUser = new UserModel()
            {
                UserName = "Jijo George",
                IsLoggedIn = true
            };
            return await Task.FromResult(objUser);
        }

        public static async Task<ConnectorResponseModel> GetRentHistory(UserModel user)
        {
            RentHistoryModel objRentH = new RentHistoryModel()
            {
                History = new List<RentHistoryDetails>()
                {
                    {
                        new RentHistoryDetails(){
                            Amount = 150.00,
                            Currency = "KWD",
                            DueDate = DateTime.Now.AddDays(-60),
                            FineAmount = 0,
                            IsPaid = true,
                            RentDate = DateTime.Now.AddDays(-65),
                            Transaction = new RentPayTransaction()
                            {
                                PaidAmount = 155.00, //Rent + TransactionCharge
                                PaidOn = DateTime.Now.AddDays(-60),
                                TransactionReference = "RNTMAY10025"
                            }
                        }
                    },
                    {
                        new RentHistoryDetails(){
                            Amount = 150.00,
                            Currency = "KWD",
                            DueDate = DateTime.Now.AddDays(-90),
                            FineAmount = 0,
                            IsPaid = true,
                            RentDate = DateTime.Now.AddDays(-95),
                            Transaction = new RentPayTransaction()
                            {
                                PaidAmount = 155.00, //Rent + TransactionCharge
                                PaidOn = DateTime.Now.AddDays(-90),
                                TransactionReference = "RNTAPR10025"
                            }
                        }
                    }
                }
            };
            return await Task.FromResult(objRentH);
        }

        public static async Task<ConnectorResponseModel> GetRentDues(UserModel user)
        {
            RentHistoryModel objRentH = new RentHistoryModel()
            {
                History = new List<RentHistoryDetails>()
                {
                    {
                        new RentHistoryDetails(){
                            Amount = 150.00,
                            Currency = "KWD",
                            DueDate = DateTime.Now.AddDays(4),
                            FineAmount = 0,
                            IsPaid = false,
                            RentDate = DateTime.Now.AddDays(-1)
                        }
                    }
                }
            };
            return await Task.FromResult(objRentH);
        }

        public static async Task<ConnectorResponseModel> PayRentDue(UserModel user)
        {
            return await Task.FromResult(new ConnectorResponseModel());
        }

        public static async Task<ConnectorResponseModel> MaintenanceBasicInfo(UserModel user)
        {
            return await Task.FromResult(new ConnectorResponseModel());
        }
        public static async Task<ConnectorResponseModel> RequestMaintenance(UserModel user)
        {
            return await Task.FromResult(new ConnectorResponseModel());
        }

        public static async Task<ConnectorResponseModel> GetAnnouncements(UserModel user)
        {
            AnnouncementModel objAnnouncement = new AnnouncementModel()
            {
                History = new List<AnnouncementHistory>()
                {
                    new AnnouncementHistory()
                    {
                        AnnouncementID = 1,
                        AnnouncementText = "Announcement One : Test Test Test Test",
                        Link = "https://www.instapaper.com/browse"
                    },
                    new AnnouncementHistory()
                    {
                        AnnouncementID = 2,
                        AnnouncementText = "Announcement Two : Test Test Test Test",
                    },
                    new AnnouncementHistory()
                    {
                        AnnouncementID = 3,
                        AnnouncementText = "Announcement Three : Test Test Test Test",
                        Link = "https://www.instapaper.com/browse"
                    },
                }
            };
            objAnnouncement.History.AddRange(objAnnouncement.History);
            return await Task.FromResult(objAnnouncement);
        }
    }
}
