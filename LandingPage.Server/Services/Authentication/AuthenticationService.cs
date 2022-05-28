using Blazored.LocalStorage;
using LandingPage.Server.Providers;
using LandingPage.Server.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace LandingPage.Server.Services.Authentication
{
    public class AuthenticationService : BaseHttpService, IAuthenticationService
    {
        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider) : base(httpClient, localStorage)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(LoginUserDto loginModel)
        {
            Response<AuthenticationResponse> response;
            try
            {
                var result = await httpClient.LoginAsync(loginModel);
                response = new Response<AuthenticationResponse>
                {
                    Data = result,
                    Success = true,
                };

                //Store Token locally
                await localStorage.SetItemAsync("accessToken", result.Token);

                //Change auth state of app
                await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<AuthenticationResponse>(exception);
            }

            return response;

        }
        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
