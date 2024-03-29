﻿using Eltizam.Resource.Resources;
using System.ComponentModel.DataAnnotations;

namespace Jupiter.Business.Models
{
    public class MasterRoleEntity : GlobalAuditFields
    {
        public MasterRoleEntity()
        {
            MasterModules = new List<MasterModuleEntity>();
        }

        public int Id { get; set; }

        public int LoggedUserId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [Display(Name = "RoleName", ResourceType = typeof(Master))]
        [StringLength(250, MinimumLength = 0)]
        public string RoleName { get; set; }

        [Display(Name = "Active", ResourceType = typeof(Master))]
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsUserAssigned { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual List<MasterModuleEntity>? MasterModules { get; set; }
    }


    public class MasterRoleListModel
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public bool? IsActive { get; set; }
    }
}
