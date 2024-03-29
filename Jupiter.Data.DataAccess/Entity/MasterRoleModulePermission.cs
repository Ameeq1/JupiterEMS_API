﻿using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterRoleModulePermission
    {
        public int RoleModuleId { get; set; }
        public int? RoleId { get; set; }
        public int? ModuleId { get; set; }
        public int? SubModuleId { get; set; }
        public bool? View { get; set; }
        public bool? Add { get; set; }
        public bool? Edit { get; set; }
        public bool? Delete { get; set; }
        public bool? Approve { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
