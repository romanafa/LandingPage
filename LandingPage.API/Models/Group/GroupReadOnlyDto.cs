using LandingPage.API.Data;
using LandingPage.API.Models.Tenant;

namespace LandingPage.API.Models.Group
{
    public class GroupReadOnlyDto
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsActiveGroup { get; set; }
        public List<TenantDto> Tenants { get; set; }
    }
}
