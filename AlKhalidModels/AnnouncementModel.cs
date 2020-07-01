using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class AnnouncementDataResponse : ConnectorResponseModel
    {
        public string ErrorMessage { get; set; }
        public AnnouncementData GetAnnouncementData { get; set; }
        public bool HasData { get; set; }
        public bool isSuccess { get; set; }
    }

    public class AnnouncementData
    {
        public string AnnCode { get; set; }
        public string AnnDescription { get; set; }
    }
}