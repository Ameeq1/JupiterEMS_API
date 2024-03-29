﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eltizam.Resource.Resources;

namespace Jupiter.Business.Models
{
    public class MasterUserEntity
    {
        public int UserId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Display(Name = "FullName", ResourceType = typeof(Master))]
        public string FullName { get; set; }

        [Display(Name = "Active", ResourceType = typeof(Master))]
        public bool IsActive { get; set; }
        [Display(Name = "Budget Approval User")]
        public bool IsManagement { get; set; }
        [Display(Name = "API Head")]
        public bool APIUser { get; set; }
        [Display(Name = "PBF Formulation Group Leader")]
        public bool FormulationGL { get; set; }
        [Display(Name = "PBF Analytical Group Leader")]
        public bool AnalyticalGL { get; set; }
        [Display(Name = "API Group Leader")]
        public bool ApigroupLeader { get; set; }
        public string DesignationName { get; set; }
        public int[] DepartmentId { get; set; }

        public int[] BusinessUnitId { get; set; }

        public int[] CountryId { get; set; }
        public int[] RegionId { get; set; }
        public string DepartmentIds { get; set; }
        public string BusinessUnitIds { get; set; }
        public string CountryIds { get; set; }
        public string RegionIds { get; set; }
        //-------Start------New Columns Added to User List------
        public string RoleName { get; set; }
        public string DepartmentName { get; set; }
        public string BusinessUnitName { get; set; }
        //-------End------New Columns Added to User List------

        public int RoleId { get; set; }

        public int MobileCountryId { get; set; }

        [Display(Name = "EmailAddress", ResourceType = typeof(Master))]
        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[Remote("CheckEmailAddressExists", "User", ErrorMessage = "Email Address already exists in database.")]
        public string EmailAddress { get; set; }

        [Display(Name = "MobileNumber", ResourceType = typeof(Master))]
        //[Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile Number should be in 10 digit format")]
        public string MobileNumber { get; set; }


        [Display(Name = "Password", ResourceType = typeof(Master))]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,16}$", ErrorMessage = "A password must have Minimum 8, " +
            "Maximum 16 characters,at least one number,at least one upper case,at least one lower case," +
            "at least one special character e.g. @$!%*?&")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string StringPassword { get; set; }
        [NotMapped]
        //[Required(ErrorMessage = "Confirm Password required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password doesn't match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassowrd { get; set; }


        [Display(Name = "Address", ResourceType = typeof(Master))]
        //[Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        public string Address { get; set; }
        public int LoggedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string WebApplicationUrl { get; set; }

    }
}

