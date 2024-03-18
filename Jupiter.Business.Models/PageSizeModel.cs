using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class PageSizeModel
    {
        public int LoginUserId { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public string? OrderByColumn { get; set; }
        public int? OrderReverse { get; set; }
    }

    public class PageLoginUserModel
    {
        public int LoginUserId { get; set; }
    }
}