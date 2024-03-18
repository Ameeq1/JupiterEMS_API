using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class DashboardPRAnalysisCountModel
    {
        public double TotalCPR { get; set; }
        public double ExcludingCriticallyILL { get; set; }
        public double PostCPR { get; set; }
        public double Survival { get; set; }
    }
}
