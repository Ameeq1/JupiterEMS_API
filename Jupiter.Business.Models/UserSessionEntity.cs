﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class UserSessionEntity
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string UserToken { get; set; }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public DateTime VallidTo { get; set; }

    }
}
