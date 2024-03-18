using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class ActionAssignedNotificationModel
    {
        public int LoginUserId { get; set; }
        public int EmergencyId { get; set; }
        public int CodeTypeId { get; set; }
        public DateTime ActivationDateTime { get; set; }
        public int LocationId { get; set; }
        public string LocationDetails { get; set; }
        public string ActionDescription { get; set; }
        public List<string> AssignedAction { get; set; }
        public DateTime ActionCompletedBy { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool isSuccess { get; set; }
    }
}
