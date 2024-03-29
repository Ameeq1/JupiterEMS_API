﻿using System.ComponentModel;

namespace Jupiter.Utility.Enums
{
    public enum RecepientActionEnum
    {
        [Description("Validation Created")]
        ValuationCreated = 1,
        [Description("Valuation Status Changed")]
        ValuationStatusChanged = 2,
        [Description("Quotation Created")]
        QuotationCreation = 3,
        [Description("Invoice Created")]
        InvoiceCreation = 4,
    }
}
