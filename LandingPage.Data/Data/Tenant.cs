using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandingPage.API.Data
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }
        public string? TenantName { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public virtual List<GroupTenant> GroupTenants { get; set; }

        [NotMapped]
        public IEnumerable<Group> Groups
        {
            get => GroupTenants?.Select(g => g.Group);
        }
    }
}
