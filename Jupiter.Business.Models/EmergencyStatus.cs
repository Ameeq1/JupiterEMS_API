using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class EmergencyStatus
    {
        public int EmergencyId { get; set; }
        public int StatusId { get; set; }
        public string? StatusNote { get; set; }
    }
}
