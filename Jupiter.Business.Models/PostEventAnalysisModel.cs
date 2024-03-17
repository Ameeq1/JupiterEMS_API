using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class PostEventAnalysisModel
    {
        public int EmergencyId { get; set; }
        public PostEventAnalysis postEventAnalysis { get; set; }
        public EmergencyPostEventAnalysisFollowUp emergencyPostEventAnalysisFollowUp { get; set; }
        public string ActionTakenByStaff { get; set; }
        public string Observation { get; set; }
        public List<EmergencyStaffInvolved> quickResponseTeams { get; set; }
        public BasicLifeSupport basicLifeSupport { get; set; }
        public UploadAttachments uploadAttachments { get; set; }
        public CAPA cAPA { get; set; }
    }
    public class PostEventAnalysis
    {
        public int TypeOfArrestId { get; set; }  // enum
        public string TypeOfArrestDescription { get; set; }
        public int TypeOfRythmId { get; set; }  //enum
        public bool IsBLSInitiated { get; set; }
        public bool IsDefibrillatorAttached { get; set; }
        public bool IsACLS { get; set; }
        public bool IsConsciousnessRegained { get; set; }
        public bool IsFamilyCounseled { get; set; }
        public TimeOnly PatientLastAccessed { get; set; }
        public decimal Temperature { get; set; }
        public decimal Pulse { get; set; }
        public decimal R { get; set; }
        public decimal BPSystolic { get; set; }
        public decimal BPDiastolic { get; set; }
        public decimal SPO2 { get; set; }
        public decimal HGT { get; set; }
        public decimal GCS { get; set; }
    }

    public class EmergencyPostEventAnalysisFollowUp
    {
        public bool IsROCSAchieved { get; set; }
        public string ROCSTransferredTo { get; set; }
        public TimeOnly ROCSTransferredTime { get; set; }  // Time
        public bool IsTTM { get; set; }
        public bool IsCS48Hrs { get; set; }
        public string TransferOutTo { get; set; }
        public TimeOnly TransferOn { get; set; }  // Time
        public string DischargedToHome { get; set; }
        public bool IsExpired { get; set; }

    }


    public class EmergencyStaffInvolved
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
    }

    public class BasicLifeSupport
    {
        public DateTime BLSStartedOn { get; set; }
        public bool IsACABFollowed { get; set; }
        public string ACABFollowedNote { get; set; }
        public bool IsBCABFollowed { get; set; }
        public string BCABFollowedNote { get; set; }
        public bool IsCCABFollowed { get; set; }
        public string CCABFollowedNote { get; set; }
        public bool IsACLSTeamOnTime { get; set; }
        public string ACLSTeamOnTimeNote { get; set; }
        public bool IsMARI { get; set; }
        public string MARINote { get; set; }
        public bool IsACLSFollowed { get; set; }
        public string ACLSFollowedNote { get; set; }
        public bool IsCrashCart { get; set; }
        public string CrashCartNote { get; set; }
        public bool IsCrashCartArrivedOnTime { get; set; }
        public string CrashCartArrivedOnTimeNote { get; set; }
        public bool IsCrashCartEquipped { get; set; }
        public string CrashCartEquippedNote { get; set; }
        public bool IsCrowdControl { get; set; }
        public string CrowdControlNote { get; set; }
        public bool IsFamilyNotified { get; set; }
        public string FamilyNotifiedNote { get; set; }
    }

    public class UploadAttachments
    {
        public string UploadPhotos { get; set; }
        public string UploadVideos { get; set; }
        public string UploadFileAttachments { get; set; }
    }

    public class CAPA
    {
        public string CorrectiveAction { get; set; }
        public string PreventiveAction { get; set; }
        public string Observation { get; set; }
    }
}
