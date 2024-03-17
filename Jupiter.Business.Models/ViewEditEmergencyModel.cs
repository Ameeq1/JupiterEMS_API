using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class ViewEditEmergencyModel
    {
        public EmergencyModel emergencyModel { get; set; }
        public CodeBlueEmergencyModel codeBlueEmergency { get; set; }
        public PostEventAnalysisModel postEventAnalysisModel { get; set; }
        public EmergencyVerificationModel emergencyVerificationModel { get; set; }  
        public EmergencyActionAssignedModel emergencyActionAssignedModel { get; set;}
        public EmergencyActionTakenModel emergencyActionTakenModel { get; set;}
        public EmergencyActionClosureModel emergencyActionClosureModel { get; set; }
    }
}
