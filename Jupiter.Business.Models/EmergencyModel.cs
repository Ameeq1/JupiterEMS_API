using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyModel
    {
        public int LoginUserId { get; set; }
        public int EmergencyId { get; set; }
        public EntryType entryType { get; set; }  // current and past
        public int CodeTypeId { get; set; }
        public int LocationId { get; set; }
        public string LocationDetails { get; set; }
        public CodeBlueDetails codeBlueDetails { get; set; }
        public CodePinkDetails codePinkDetails { get; set; }
        public CodeHazmatDetails codeHazmatDetails { get; set; }
        public CodePurpleDetails codePurpleDetails { get; set; }
        public CodeGreyDetails codeGreyDetails { get; set; }
        public CodeRedDetails codeRedDetails { get; set; }
        public CodeBlackDetails codeBlackDetails { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool isActivated { get; set; }
    }

    public class EntryType
    {
        public int EntryTypeId { get; set; }
        public EntryDetails entryDetails { get; set; }
    }

    public class EntryDetails
    {
        public DateTime? ActivationDateTime { get; set; }
        public DateTime? DeactivationDateTime { get; set; }
        public string ReasonLateEntry { get; set; }
        public string Remarks { get; set; }
    }

    public class CodeBlueDetails
    {
        public CodeBlueVictimDetails victimDetails { get; set; }
        public CodeBlueCheckList checkList { get; set; }
    }

    public class CodeBlueVictimDetails
    {
        public int VictimTypeId { get; set; }
        public string VictimRefNo { get; set; }
        public List<string> VictimCondition { get; set; }
    }

    public class CodeBlueCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
    }
    public class CodePinkDetails
    {
        public CodePinkPersonDetails codePinkPersonDetails { get; set; }
        public CodePinkCheckList codePinkCheckList { get; set; }
    }

    public class CodePinkPersonDetails
    {
        public int PersonDetailId { get; set; }
        public string PersonDetailRefNo { get; set; }
        public int Age { get; set; }
        public string SkinColor { get; set; }
        public string Dress { get; set; }
        public string Address { get; set; }
    }

    public class CodePinkCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
        public bool Checklist4 { get; set; }
        public string Checklist4Reason { get; set; }
        public bool Checklist5 { get; set; }
        public string Checklist5Reason { get; set; }
    }

    public class CodeHazmatDetails
    {
        public string IncidentDiscription { get; set; }
        public CodeHazmatCheckList hazmatCheckList { get; set; }
    }

    public class CodeHazmatCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
    }

    public class CodePurpleDetails
    {
        public CodePurpleCheckList codePurpleCheckList { get; set; }
    }

    public class CodePurpleCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
    }

    public class CodeGreyDetails
    {
        public string IncidentDiscription { get; set; }
        public CodeGreyCheckList greyCheckList { get; set; }
    }

    public class CodeGreyCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
    }

    public class CodeRedDetails
    {
        public string IncidentDiscription { get; set; }
        public CodeRedCheckList redCheckList { get; set; }
    }

    public class CodeRedCheckList
    {
        public bool Checklist1 { get; set; }
        public string Checklist1Reason { get; set; }
        public bool Checklist2 { get; set; }
        public string Checklist2Reason { get; set; }
        public bool Checklist3 { get; set; }
        public string Checklist3Reason { get; set; }
        public bool Checklist4 { get; set; }
        public string Checklist4Reason { get; set; }
        public bool Checklist5 { get; set; }
        public string Checklist5Reason { get; set; }
        public bool Checklist6 { get; set; }
        public string Checklist6Reason { get; set; }
    }

    public class CodeBlackDetails
    {
        public string IncidentDiscription { get; set; }
    }
}
