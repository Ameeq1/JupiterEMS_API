using Jupiter.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Core.Interface
{
    public interface IReportService
    {
        Task<List<EmergencyReportModel>> GetAllEmergencyReportList();
        Task<List<EmergencyReportModel>> GetAllMockDrillEmergencyReportList();
    }
}
