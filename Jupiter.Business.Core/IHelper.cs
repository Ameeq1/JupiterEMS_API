﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jupiter.Business.Models;

namespace Jupiter.Business.Core
{
    public interface IHelper
    {
        UserSessionEntity GetLoggedInUser();
    }
}
