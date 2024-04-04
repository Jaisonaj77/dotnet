using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class Lead
    {
        public Lead()
        {
            LeadAttachments = new HashSet<LeadAttachment>();
            LeadNotes = new HashSet<LeadNote>();
            LeadPreferences = new HashSet<LeadPreference>();
        }

        public int Id { get; set; }
        public int? LeadSourceId { get; set; }
        public int? LeadTypeId { get; set; }
        public int? ClientTypeId { get; set; }
        public int? LeadStatusId { get; set; }
        public int? LeadOwnerId { get; set; }
        public string? Salutation { get; set; }
        public string? LeadName { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? AlternateNo { get; set; }
        public string? Company { get; set; }
        public string? Designation { get; set; }
        public string? Industry { get; set; }
        public string? Website { get; set; }
        public string? CurrentAddress { get; set; }
        public decimal? AnnualRevenue { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Nationality { get; set; }
        public string? PrefferedTimeToCall { get; set; }
        public string? Description { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ClientType? ClientType { get; set; }
        public virtual User? LeadOwner { get; set; }
        public virtual LeadSource? LeadSource { get; set; }
        public virtual LeaseStatus? LeadStatus { get; set; }
        public virtual LeadType? LeadType { get; set; }
        public virtual ICollection<LeadAttachment> LeadAttachments { get; set; }
        public virtual ICollection<LeadNote> LeadNotes { get; set; }
        public virtual ICollection<LeadPreference> LeadPreferences { get; set; }
    }
}
