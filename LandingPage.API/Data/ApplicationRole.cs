using Microsoft.AspNetCore.Identity;

namespace LandingPage.API.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
