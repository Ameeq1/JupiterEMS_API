using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jupiter.Resource.Resources;

namespace Jupiter.Business.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [EmailAddress(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "EmailValid")]

        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
