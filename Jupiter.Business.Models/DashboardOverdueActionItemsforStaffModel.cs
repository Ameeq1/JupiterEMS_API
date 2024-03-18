using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class DashboardOverdueActionItemsforStaffModel
    {
        public int EmergencyId { get; set; }
        public string CodeType { get; set; }
        public string Location { get; set; }
        public DateTime TobecompletedbyDate { get; set; }
    }
}
