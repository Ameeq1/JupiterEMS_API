using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class DashboardCodewiseAnalysisCountModel
    {
        public double TotalCB { get; set; }
        public double Actual { get; set; }
        public double False { get; set; }
        public double RequiredCPR { get; set; }
        public double Discharged { get; set; }
        public double Expired { get; set; }
    }
}
