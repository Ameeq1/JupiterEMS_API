using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyResponseModel
    {
        public int LoginUserId { get; set; }
        public int EmergencyId { get; set; }
        public bool EmergencyResponse { get; set; }  // enum
        public string EstimatedTimeArrival { get; set; }
        public string ReasonUnavailablity { get; set; }
    }
}
