using Jupiter.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Core.Interface
{
    public interface IDashBoardService
    {
        Task<List<DashboardEmergencyModel>> GetActiveEmegencyList();
        Task<List<DashboardEmergencyModel>> GetTodayEmegencyList(DateTime today);
        Task<List<DashboardReportedEmergencyModel>> GetReportedEmergencies(DateTime fromDate, DateTime toDate);
        Task<List<DashboardRecentEmergencyModel>> GetRecentEmergency();

        Task<List<DashboardOverdueActionItemsforStaffModel>> GetAssignedActionItems();

        Task<List<DashboardOverdueActionItemsforStaffModel>> GetOverdueActionItemsforStaff();
        
        Task<List<DashboardCodewiseAnalysisCountModel>> GetCodewiseAnalysisCount(DateTime fromDate, DateTime toDate);

        Task<List<DashboardPRAnalysisCountModel>> GetCPRAnalysisAdult(DateTime fromDate, DateTime toDate);

        Task<List<DashboardPRAnalysisCountModel>> GetCPRAnalysisPaediatric(DateTime fromDate, DateTime toDate);

    }
}
