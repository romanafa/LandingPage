namespace LandingPage.API.Models.User
{
    public class AuthenticationResponse
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
    }
}
