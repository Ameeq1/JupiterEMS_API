using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class PostEventAnalysisNotificationModel
    {
        public int LoginUserId { get; set; }
        public int EmergencyId { get; set; }
        public int CodeTypeId { get; set; }
        public DateTime ActivationDateTime { get; set; }
        public int LocationId { get; set; }
        public string LocationDetails { get; set; }
        public string CodeCaptainName { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
