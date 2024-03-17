using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyActionClosureModel
    {
        public int EmergencyId { get; set; }
        public int VerifiedBy { get; set; }
        public string? VerifiedNote { get; set; }
    }
}
