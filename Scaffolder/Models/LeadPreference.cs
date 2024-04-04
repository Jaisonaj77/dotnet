using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class LeadPreference
    {
        public int Id { get; set; }
        public int? LeadId { get; set; }
        public string? DesiredLocation { get; set; }
        public string? PreferredNeighbourhood { get; set; }
        public string? PreferredPropertyType { get; set; }
        public int? NoOfBedrooms { get; set; }
        public int? NoOfBathrooms { get; set; }
        public string? PriceRange { get; set; }
        public string? BuildingType { get; set; }
        public int? FloorPreference { get; set; }
        public string? ViewPreference { get; set; }
        public bool? IsCorporate { get; set; }
        public int? NumberOfUnits { get; set; }
        public string? Area { get; set; }
        public DateTime? DesiredMoveInDate { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Lead? Lead { get; set; }
    }
}
