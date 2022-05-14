using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Data
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }
        public string? TenantName { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public int? GroupId { get; set; }
        public virtual Group? Group { get; set; }
    }
}
