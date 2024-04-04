using System;
using System.Collections.Generic;

namespace Scaffolder.Models
{
    public partial class User
    {
        public User()
        {
            Leads = new HashSet<Lead>();
        }

        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? MobileNo { get; set; }
        public string? Designation { get; set; }
        public string? UserRole { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
    }
}
