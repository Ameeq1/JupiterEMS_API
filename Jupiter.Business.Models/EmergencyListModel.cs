using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyListModel
    {
        public int EmergencyId { get; set; }
        public int CodeTypeId { get;set; }
        public DateTime? ActivationDateTime { get; set; }
        public DateTime? DeactivationDateTime { get; set; }
        public string ReportedBy { get; set; }
        public int LocationId { get; set; }
        public string LocationDetails { get; set; }
        public TimeOnly TimeOfCompletion { get; set; }
        public bool isActivationStatus { get; set; }
        public bool isPostEventAnalysisStatus { get; set; }
        public bool isVerificationStatus { get; set; }
        public bool isActionItemsStatus { get; set; }
    }
}
