using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class AnnouncementModel : ConnectorResponseModel
    {
        public List<AnnouncementHistory> History { get; set; }
    }

    public class AnnouncementHistory
    {
        public long AnnouncementID { get; set; }
        public string AnnouncementText { get; set; }
        public string Link { get; set; }
    }
}