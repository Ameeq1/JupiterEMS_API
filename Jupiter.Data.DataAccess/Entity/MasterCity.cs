using System;
using System.Collections.Generic;

namespace Jupiter.Data.DataAccess.Entity
{
    public partial class MasterCity
    {
        

        public int Id { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string? CityName { get; set; }
        public string? Stdcode { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

       
    }
}
