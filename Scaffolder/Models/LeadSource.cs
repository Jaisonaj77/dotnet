using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class LeadSource
    {
        public LeadSource()
        {
            Leads = new HashSet<Lead>();
        }

        public int Id { get; set; }
        public string? Source { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
    }
}
