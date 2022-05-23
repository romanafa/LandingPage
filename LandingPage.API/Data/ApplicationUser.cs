using Microsoft.AspNetCore.Identity;

namespace LandingPage.API.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? IsActive { get; set; } = true;
        public virtual ICollection<Group>? Groups { get; set; }
        //public ICollection<IdentityUserRole> UserRoles { get; set; }
    }
}
