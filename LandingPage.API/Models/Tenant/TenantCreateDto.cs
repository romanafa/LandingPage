using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Models.Tenant
{
    public class TenantCreateDto
    {
        [Required(ErrorMessage = "Tenant navn mangler")]
        public string TenantName { get; set; }
        [Required(ErrorMessage = "Url mangler")]
        public string Url { get; set; }
        public bool IsActive { get; set; }
        [Range(0, int.MaxValue)]
        public int? GroupId { get; set; }
    }
}
