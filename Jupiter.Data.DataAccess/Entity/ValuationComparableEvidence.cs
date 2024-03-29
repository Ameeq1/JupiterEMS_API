﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class ValuationComparableEvidence
    {
        public int Id { get; set; }
        public int? RequestId { get; set; }
        public string? Type { get; set; }
        public int? Size { get; set; }
        public string? Remarks { get; set; }
        public decimal? RateSqFt { get; set; }
        public decimal? Price { get; set; }
        public string? AddtionalComments { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ValuationRequest? Request { get; set; }
    }
}
