using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterUser
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public string? LicenseNo { get; set; }
        public int? CompanyId { get; set; }
        public int? ResourceId { get; set; }
        public string Password { get; set; } = null!;
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string? CompanyName { get; set; }
        public string? Email { get; set; }
        public int? RoleId { get; set; }
        public DateTime? ForgotPasswordDateTime { get; set; }
        public string? ForgotPasswordToken { get; set; }
        public int? ReportsTo { get; set; }
        public int? UserTypeId { get; set; }
        public string? UserName { get; set; }
        public int? ProfileAttachmentId { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ApproverLevelId { get; set; }
        public int? GenderId { get; set; }
        //public string? Gender { get; set; }

       
    }
}
