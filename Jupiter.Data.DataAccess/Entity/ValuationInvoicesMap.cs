﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class ValuationInvoicesMap
    {
        public int Id { get; set; }
        public int ValuationQuotationId { get; set; }
        public int ValuationReceivedInvoiceId { get; set; }
        public string? Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ValuationQuotation ValuationQuotation { get; set; } = null!;
        public virtual ValuationInvoice1 ValuationReceivedInvoice { get; set; } = null!;
    }
}
