﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class ValuationRequestStatusHistory
    {
        public long Id { get; set; }
        public int StatusId { get; set; }
        public long ValuationRequestId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string? StatusComment { get; set; }
    }
}
