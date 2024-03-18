using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    /// <summary>
    /// sa
    /// </summary>
    public partial class SiteDescription
    {
        public int Id { get; set; }
        public int ValuationRequestId { get; set; }
        public string? Location { get; set; }
        public decimal? InternalArea { get; set; }
        public decimal? ExternalArea { get; set; }
        public int? Floor { get; set; }
        public int? Room { get; set; }
        public int? Bedrooms { get; set; }
        public string? Storage { get; set; }
        public int? Quantity { get; set; }
        public string? AdditionComment { get; set; }
        public string? PropertyCondition { get; set; }
        public string? AdditionalNotes { get; set; }
        public string? Others { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ValuationRequest ValuationRequest { get; set; } = null!;
    }
}
