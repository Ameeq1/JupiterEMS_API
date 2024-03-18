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
        Task<IActionResult> GetAllEmergencyReportList();
        Task<IActionResult> GetAllMockDrillEmergencyReportList();
    }
}
