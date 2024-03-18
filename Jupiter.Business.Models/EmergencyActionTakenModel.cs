using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyActionTakenModel
    {
        public int EmergencyId {  get; set; }
        public string? ActionDescription { get; set; }
        public string? Attachment { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime SubmittedDateTime { get; set; }
    }
}


