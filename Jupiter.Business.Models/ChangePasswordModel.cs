﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class ChangePasswordModel
    {
        public int UserId { get; set; }

        [Display(Name = "Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,16}$", ErrorMessage = "A password must have Minimum 8, " +
           "Maximum 16 characters,at least one number,at least one upper case,at least one lower case," +
           "at least one special character e.g. @$!%*?&")]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }

        [NotMapped]
        [Compare("NewPassword", ErrorMessage = "Password and Confirm Password doesn't match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class ApiResponse
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
