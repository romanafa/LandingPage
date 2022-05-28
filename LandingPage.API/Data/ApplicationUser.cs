using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LandingPage.API.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        public bool? IsActive { get; set; } = true;
        public ICollection<Group> Groups { get; set; }
        public virtual List<ApplicationUserRole> UserRoles { get; set; }

        [NotMapped]
        public IEnumerable<ApplicationRole> Roles
        {
            get => UserRoles.Select(x => x.Role);
        }

    }
}
