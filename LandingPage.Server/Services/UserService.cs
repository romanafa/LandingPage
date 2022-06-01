using AutoMapper;
using Blazored.LocalStorage;
using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public class UserService : BaseHttpService, IUserService
    {
        private readonly IClient client;
        private readonly IMapper mapper;

        public UserService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            this.client = client;
            this.mapper = mapper;
        }

        public async Task<Response<int>> Create(UserCreateDto user)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.UsersPOSTAsync(user);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Delete(string id)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.UsersDELETEAsync(id);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Edit(string id, UserUpdateDto user)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.UsersPUTAsync(id, user);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<UserReadOnlyDto>> Get(string id)
        {
            Response<UserReadOnlyDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.UsersGETAsync(id);
                response = new Response<UserReadOnlyDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<UserReadOnlyDto>(exception);
            }

            return response;
        }

        public async Task<Response<UserUpdateDto>> GetForUpdate(string id)
        {
            Response<UserUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.UsersGETAsync(id);
                response = new Response<UserUpdateDto>
                {
                    Data = mapper.Map<UserUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<UserUpdateDto>(exception);
            }

            return response;
        }

        public async Task<Response<List<UserReadOnlyDto>>> GetUsers()
        {
            Response<List<UserReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.UsersAllAsync();
                response = new Response<List<UserReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<UserReadOnlyDto>>(exception);
            }

            return response;
        }

        public async Task<Response<List<RoleDto>>> GetAllRoles()
        {
            Response<List<RoleDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.RolesAsync();
                response = new Response<List<RoleDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<RoleDto>>(exception);
            }

            return response;
        }
    }
}
