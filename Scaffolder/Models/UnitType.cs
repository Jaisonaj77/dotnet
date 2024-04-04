using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class UnitType
    {
        public int Id { get; set; }
        public string? UnitTypeCode { get; set; }
        public string? Type { get; set; }
        public string? InternalUnitArea { get; set; }
        public string? BalconyArea { get; set; }
        public string? TotalUnitArea { get; set; }
        public string? CoolingArea { get; set; }
        public int? NoOfBedrooms { get; set; }
        public int? NoOfBathRooms { get; set; }
        public int? MaidRoom { get; set; }
        public int? OfficeRooms { get; set; }
        public int? StudyRoom { get; set; }
        public string? BasicRent { get; set; }
        public string? QatarCoolPrice { get; set; }
        public string? ElectricityPrice { get; set; }
        public string? WaterPrice { get; set; }
        public string? GasPrice { get; set; }
        public int? MaxAllowedOccupants { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
