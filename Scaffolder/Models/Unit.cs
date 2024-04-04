using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class Unit
    {
        public int Id { get; set; }
        public string? UnitCode { get; set; }
        public int? UnitFloor { get; set; }
        public string? UnitBasicRent { get; set; }
        public int? CompanyId { get; set; }
        public int? UnitTypeId { get; set; }
        public int? BusinessEntityId { get; set; }
        public int? BuildingId { get; set; }
        public int? ViewMasterId { get; set; }
        public int? UnitStatusId { get; set; }
        public int? OccupancsyStatusId { get; set; }
        public int? AvailabilityStatusId { get; set; }
        public int? LeaseStatusId { get; set; }
        public string? UnitLayout { get; set; }
        public string? ElectricityMeterNo { get; set; }
        public string? WaterMeterNo { get; set; }
        public string? QatarCoolMeterNo { get; set; }
        public string? ParkingBayNo { get; set; }
        public int? ParkingCount { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
