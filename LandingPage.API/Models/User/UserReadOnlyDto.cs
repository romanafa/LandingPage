namespace LandingPage.API.Models.User
{
    public class UserReadOnlyDto
    {
        public string Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
