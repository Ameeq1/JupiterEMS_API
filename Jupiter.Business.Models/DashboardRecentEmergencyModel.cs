using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class DashboardRecentEmergencyModel
    {
        public int EmergencyId { get; set; }
        public string CodeType { get; set; }
        public DateTime CodeActivationDateTime { get; set; }
        public string ReportedBy { get; set; }
        public string Location { get; set; }
        public DateTime CodeDeactivationDateTime { get; set; }
        public DateTime TimeofCompletion { get; set; }
        public Boolean DeactivationStatus { get; set; }
        public Boolean PostEventAnalysis { get; set; }
        public Boolean Verification { get; set; }
        public Boolean ActionItem { get; set; }
    }
}
