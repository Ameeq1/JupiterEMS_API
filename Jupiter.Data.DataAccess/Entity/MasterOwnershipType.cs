﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterOwnershipType
    {
        public int Id { get; set; }
        public string OwnershipType { get; set; } = null!;
        public int? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
