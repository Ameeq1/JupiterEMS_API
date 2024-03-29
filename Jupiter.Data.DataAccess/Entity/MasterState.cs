﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterState
    {
        public MasterState()
        {
            MasterLocations = new HashSet<MasterLocation>();
            MasterUserAddresses = new HashSet<MasterUserAddress>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string? StateName { get; set; }
        public string? StateCode { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MasterCountry Country { get; set; } = null!;
        public virtual ICollection<MasterLocation> MasterLocations { get; set; }
        public virtual ICollection<MasterUserAddress> MasterUserAddresses { get; set; }
    }
}
