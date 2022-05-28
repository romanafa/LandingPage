using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Data
{
    public class GroupTenant
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
