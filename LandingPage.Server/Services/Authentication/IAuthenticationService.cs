using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
