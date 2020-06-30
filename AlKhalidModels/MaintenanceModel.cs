using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhalidModels
{
    public class MaintenanceModel
    {
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string Subject { get; set; }
        public string RequestReffNo { get; set; }
        public bool IsRequested { get; set; }
    }
}
