using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandingPage.API.Data
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public bool IsActiveGroup { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
        public virtual List<GroupTenant> GroupTenants { get; set; }

        [NotMapped]
        public IEnumerable<Tenant> Tenants
        {
            get => GroupTenants?.Select(t => t.Tenant);
        }
    }
}
