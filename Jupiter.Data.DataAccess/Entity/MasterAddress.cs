﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterAddress
    {
        public int Id { get; set; }
        public int? TableKeyId { get; set; }
        public string? TableName { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? PinNo { get; set; }
        public string? Landmark { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public bool IsActive { get; set; }
        public string? AlternatePhone { get; set; }
        public string? Email { get; set; }
        public string? AlternateEmail { get; set; }
        public string? Phone { get; set; }
        public string? Landlinephone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string? AlternatePhoneExt { get; set; }
        public string? PhoneExt { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Zone { get; set; }

        public virtual MasterCity? City { get; set; }
    }
}
