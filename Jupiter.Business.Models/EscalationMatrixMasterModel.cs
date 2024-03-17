using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EscalationMatrixMasterModel
    {
        public int Id { get; set; }
        public string Person1 { get; set; }
        public string Person2 { get; set; }
        public string Person3 { get; set; }
        public DateTime TriggerTime1 { get; set; }
        public DateTime TriggerTime2 { get; set; }
        public DateTime TriggerTime3 { get; set; }
        public int EscalationType { get; set; }

    }
}
