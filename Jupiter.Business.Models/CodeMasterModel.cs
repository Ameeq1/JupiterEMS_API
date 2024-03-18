using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Business.Models
{
    public class CodeMasterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ExtensionNo { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int ColorCodeId { get; set; }
        public int OwnerId { get; set; }
        public int Description { get; set; }
        public int LoginUserId { get; set; }
        

    }

    public class CodeTeamMasterModel
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpCode { get; set; }
        public string EmpExtNo { get; set; }
        public string EmpPhone { get; set; }
        public string EmployeeEmail { get; set; }
        public int MasterCodeId { get; set; }
        public Boolean IsCaptain { get; set; }
        public int LoginUserId { get; set; }
    }
    public class CodeWiseTeamCountModel
    {
        public int Id { get; set; }
        public int ColorCodeId { get; set; }
        public int TotalMemberCount { get; set; }

    }

}
