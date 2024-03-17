using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyActionAssignedModel
    {
        public int EmergencyId { get; set; }
        public List<ActionAssignItem> ActionItem { get; set; }
    }

    public class ActionAssignItem
    {
        public string ActionDescription { get; set; }
        public List<string> ActionAssignTo { get; set; }
        public DateTime? ActionCompletedBy { get; set; }
    }
}
