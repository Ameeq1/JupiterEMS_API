﻿namespace Jupiter.Utility.Enums
{
    public enum Master_ApplicationStatus
    {
        PIDFInProgress = 1,
        PIDFSubmitted = 2,
        PIDFApproved = 3,
        PIDFRejected = 4,
        IPDInProgress = 5,
        IPDSubmitted = 6,
        IPDApproved = 7,
        IPDRejected = 8,
        MedicalSubmitted = 9,
        CommercialInProgress = 10,
        CommercialSubmitted = 11,
        PBFInProgress = 12,
        PBFSubmitted = 13,
        APIInProgress = 14,
        APISubmitted = 15,
        FinanceInProgres = 16,
        FinanceSubmitted = 17,
        FinanceApproved = 18,
        FinanceRejected = 19,
        ManagementApproved = 20,
        ManagementRejected = 21,
        Completed = 22,
        PBFRejected = 24
        //PIDFCreated = 1,
        //PIDFPendingApproval = 2,
        //PIDFApproved = 3,
        //PIDFRejected = 4,
        //IPDCreated = 5,
        //IPDBDPendingApproval = 6,
        //IPDBDApproved = 7,
        //IPDBDRejected = 8,
        //FinancePendingApproval = 9,
        //FinanceApproved = 10,
        //FinanceRejected = 11,
        //FinalRejected = 12,
        //FinalApproved = 13,
        //Completed = 14
    }

    public enum PIDFScreen
    {
        PIDF = 1,
        IPD = 2,
        Medical = 3,
        Commercial = 4,
        API = 5,
        PBF = 6,
        Finance = 7,
        Management = 8,
        Project = 9
    }

    public enum ClinicalBioStudyType
    {
        PilotBioFasting = 1,
        PilotBioFed = 2,
        PivotalBioFasting = 3,
        PivotalBioFed = 4
    }
}