using System.ComponentModel.DataAnnotations;

namespace LandingPage.API.Data
{
    public class Group
    {
        public Group()
        {
            Tenants = new HashSet<Tenant>();
        }

        [Key]
        public int GroupId { get; set; }
        public string? GroupName { get; set; }
        public bool IsActiveGroup { get; set; }
        //public virtual ICollection<ApplicationUser>? Users { get; set; }
        public virtual ICollection<Tenant> Tenants { get; set; }
    }
}
