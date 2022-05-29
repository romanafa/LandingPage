using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandingPage.API.Data
{
    public class ApplicationRole : IdentityRole
    {
        public List<ApplicationUserRole> UserRoles { get; set; }
        [NotMapped]
        public IEnumerable<ApplicationRole> Roles
        {
            get => UserRoles.Select(x => x.Role);
        }
    }
}
