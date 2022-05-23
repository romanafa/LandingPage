﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LandingPage.Server.Providers
{
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService localStorage;
        private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler;
        public ApiAuthenticationStateProvider(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
            jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var notLoggedInUser = new ClaimsPrincipal(new ClaimsIdentity());
            var savedToken = await localStorage.GetItemAsync<string>("accessToken");
            
            //check if token exists
            if (savedToken == null)
            {
                return new AuthenticationState(notLoggedInUser);
            }

            //get token content
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(savedToken);

            //check if the token is valid - not expired 
            if (tokenContent.ValidTo < DateTime.Now)
            {
                await localStorage.RemoveItemAsync("accessToken");
                return new AuthenticationState(notLoggedInUser);
            }

            var claims = await GetClaims();

            //list of claims came from jwt authentication
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));

            return new AuthenticationState(user);


        }
        public async Task LoggedIn()
        {
            var claims = await GetClaims();
            var user = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            var authState = Task.FromResult(new AuthenticationState(user));

            //notify of authentication state change
            NotifyAuthenticationStateChanged(authState);
        }

        public async Task LoggedOut()
        {
            //remove token from local storage on logout
            await localStorage.RemoveItemAsync("accessToken");
            var notLoggedInUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(notLoggedInUser));

            //notify of authentication state change
            NotifyAuthenticationStateChanged(authState);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var savedToken = await localStorage.GetItemAsync<string>("accessToken");
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(savedToken);
            var claims = tokenContent.Claims.ToList();
            claims.Add(new Claim(ClaimTypes.Name, tokenContent.Subject));
            return claims;
        }
    }
}
