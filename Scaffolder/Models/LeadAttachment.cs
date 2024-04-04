using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class LeadAttachment
    {
        public int Id { get; set; }
        public int? LeadId { get; set; }
        public string? FileName { get; set; }
        public string? FileSize { get; set; }
        public string? FilePath { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Lead? Lead { get; set; }
    }
}
