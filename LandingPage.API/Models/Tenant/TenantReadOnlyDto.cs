namespace LandingPage.API.Models.Tenant
{
    public class TenantReadOnlyDto
    {
        public int TenantId { get; set; }
        public string? TenantName { get; set; }
        public string? Url { get; set; }
        public bool IsActive { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
