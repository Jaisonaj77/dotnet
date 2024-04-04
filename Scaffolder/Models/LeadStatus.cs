using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class LeadStatus
    {
        public int Id { get; set; }
        public string? Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
