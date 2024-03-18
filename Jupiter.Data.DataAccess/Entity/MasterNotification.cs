using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterNotification
    {
        public int Id { get; set; }
        public int? ValuationRequestId { get; set; }
        public int? StatusId { get; set; }
        public string? Subject { get; set; }
        public string? ToEmails { get; set; }
        public string? Body { get; set; }
        public DateTime? SentDatetime { get; set; }
        public bool IsEmailSent { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ReadBy { get; set; }
        public DateTime? ReadDate { get; set; }

      
    }
}
