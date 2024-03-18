using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyReportModel
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string CodeType { get; set; }
        public DateTime ActivationDate { get; set; }
        public TimeSpan ActivationTime { get; set; }
        public DateTime DeactivationDate { get; set; }
        public TimeSpan DeactivationTime { get; set; }
        public string ActivatedBy { get; set; }
        public string DeactivatedBy { get; set; }
        public string CodeCaptain { get; set; }
        public TimeSpan CodeCaptainArrivalTime { get; set; }
        public string IncidentDetails { get; set; }
        public string Tat { get; set; }
        public string DeactivationStatus { get; set; }
        public string PostEventAnalysis { get; set; }
        public string ActionableItems { get; set; }
        public string Verification { get; set; }
    }
}
