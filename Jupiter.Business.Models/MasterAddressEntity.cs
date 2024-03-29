﻿using Eltizam.Resource.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class MasterAddressEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [StringLength(250, MinimumLength = 1)]
        public string? Address1 { get; set; }

        [StringLength(250, MinimumLength = 1)]
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        [StringLength(10, MinimumLength = 5)]
        public string? PinNo { get; set; }
        public string? Zone { get; set; }
        public string? Landmark { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The 'Country' field is required.")]
        public int CountryId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The 'State' field is required.")]
        public int StateId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The 'City' field is required.")]
        public int CityId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string? Email { get; set; }

        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string? AlternateEmail { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [StringLength(12, MinimumLength = 5)]
        public string? Phone { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "The 'PhoneExt' field is required.")]
        public string PhoneExt { get; set; }

        [StringLength(12, MinimumLength = 5)]
        public string? AlternatePhone { get; set; }

        // [StringLength(12, MinimumLength = 1)]
        public string? AlternatePhoneExt { get; set; }

        [StringLength(12, MinimumLength = 5)]
        public string? Landlinephone { get; set; }

        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public string? StateName { get; set; }
        public string? CountryName { get; set; }
        public string? CityName { get; set; }
    }
}
