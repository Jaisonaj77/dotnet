using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class Building
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? NameEn { get; set; }
        public string? NameAr { get; set; }
        public int? BusinessEntityId { get; set; }
        public int? CompanyId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
