using LandingPage.API.Models.Group;

namespace LandingPage.API.Models.User
{
    public class UserReadOnlyDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}
