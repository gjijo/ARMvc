using System;
using System.Collections.Generic;
using System.Text;

namespace AlKhalidModels
{
    public class RentHistoryModel : ConnectorResponseModel
    {
        public List<RentHistoryDetails> History { get; set; }
        public List<long> PendingRents { get; set; }
        public double PendingAmount { get; set; }
        public string Currency { get; set; }
    }

    public class RentHistoryDetails
    {
        public long RentID { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public double FineAmount { get; set; }
        public bool IsPaid { get; set; }

        public RentPayTransaction Transaction { get; set; }
    }

    public class RentPayTransaction
    {
        public DateTime PaidOn { get; set; }
        public double PaidAmount { get; set; }
        public string TransactionReference { get; set; }
    }
}
