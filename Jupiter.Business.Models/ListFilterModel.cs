﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class ListFilterModel
    {
        public int? CodeTypeId { get; set; }
        public string? ReportedBy { get; set; }
        public int? LocationId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? SearchText { get; set; }
    }
}
