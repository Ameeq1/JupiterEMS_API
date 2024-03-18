using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.Data.DataAccess.Entity
{
    public class Emergency
    {
        public int Id { get; set; }
        public int MasterCodeTypeId { get; set; }
        public int LocationId { get; set; }
        public int EntryTypeId { get; set; }
        public string LocationDetails { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
