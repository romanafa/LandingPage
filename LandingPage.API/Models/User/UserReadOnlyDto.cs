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
        public string Role { get; set; }
    }
}
