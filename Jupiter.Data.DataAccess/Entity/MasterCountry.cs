﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterCountry
    {
        public MasterCountry()
        {
            MasterLocations = new HashSet<MasterLocation>();
            MasterStates = new HashSet<MasterState>();
            MasterUserAddresses = new HashSet<MasterUserAddress>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; } = null!;
        public string? CountryCode { get; set; }
        public string? IsdcountryCode { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<MasterLocation> MasterLocations { get; set; }
        public virtual ICollection<MasterState> MasterStates { get; set; }
        public virtual ICollection<MasterUserAddress> MasterUserAddresses { get; set; }
    }
}
