using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class GetAnnouncementDataResponse : ConnectorResponseModel
    {
        private ResponseStatus responseStatus;
        private GetAnnouncementDataResponseResult result;
        private CompanyResult CompanyRes;

        public GetAnnouncementDataResponse()
        {
            responseStatus = new ResponseStatus();
            result = new GetAnnouncementDataResponseResult();
            CompanyRes = new CompanyResult();
        }
        public ResponseStatus ResponseStatus
        {
            get { return responseStatus; }
            set { responseStatus = value; }
        }
        public GetAnnouncementDataResponseResult Result
        {
            get { return result; }
            set { result = value; }

        }
        public CompanyResult CompanyResult
        {
            get { return CompanyRes; }
            set { CompanyRes = value; }
        }
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
    public class GetAnnouncementDataResponseResult
    {
        public string ErrorMessage;
        public bool isSuccess;
        public bool HasData;

        private GetAnnouncement Announcements;

        public GetAnnouncementDataResponseResult()
        {
            Announcements = new GetAnnouncement();
        }
        public GetAnnouncement GetAnnouncementData
        {
            get { return Announcements; }
            set { Announcements = value; }
        }
    }
    public class GetAnnouncement
    {
        public string AnnCode { get; set; }
        public string AnnDescription { get; set; }

    }
}