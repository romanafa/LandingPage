namespace LandingPage.API.Models.Tenant
{
    public class TenantDto
    {
        public int TenantId { get; set; }
        public string? TenantName { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
    }
}
