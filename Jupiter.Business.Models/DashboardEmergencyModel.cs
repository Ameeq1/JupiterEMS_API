using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class DashboardEmergencyModel
    {
        public int EmergencyId { get; set; }
        public int CodeId { get; set; }
        public DateTime ReportedTime { get; set; }
        public string Status { get; set; }
    }
}
