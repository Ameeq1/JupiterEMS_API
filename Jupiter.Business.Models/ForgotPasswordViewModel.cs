﻿using Eltizam.Resource.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class ForgotPasswordViewModel
    {
        //[Required]
        //[EmailAddress(ErrorMessageResourceName = "EmailValid")]
        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [EmailAddress(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "EmailValid")]
        public string Email { get; set; }
        public string WebApplicationUrl { get; set; }
    }
}
