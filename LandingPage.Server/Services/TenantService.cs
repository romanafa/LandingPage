using AutoMapper;
using Blazored.LocalStorage;
using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public class TenantService : BaseHttpService, ITenantService
    {
        private readonly IClient client;
        private readonly IMapper mapper;

        public TenantService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            this.client = client;
            this.mapper = mapper;
        }

        public async Task<Response<int>> Create(TenantCreateDto tenant)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.TenantsPOSTAsync(tenant);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Delete(int id)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.TenantsDELETEAsync(id);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Edit(int id, TenantUpdateDto tenant)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.TenantsPUTAsync(id, tenant);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<TenantReadOnlyDto>> Get(int id)
        {
            Response<TenantReadOnlyDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.TenantsGETAsync(id);
                response = new Response<TenantReadOnlyDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<TenantReadOnlyDto>(exception);
            }

            return response;
        }

        public async Task<Response<TenantUpdateDto>> GetForUpdate(int id)
        {
            Response<TenantUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.TenantsGETAsync(id);
                response = new Response<TenantUpdateDto>
                {
                    Data = mapper.Map<TenantUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<TenantUpdateDto>(exception);
            }

            return response;
        }

        public async Task<Response<List<TenantReadOnlyDto>>> GetTenants()
        {
            Response<List<TenantReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.TenantsAllAsync();
                response = new Response<List<TenantReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<TenantReadOnlyDto>>(exception);
            }

            return response;
        }

        public Task<Response<List<TenantReadOnlyDto>>> GetTenantsWithGroups()
        {
            throw new NotImplementedException();
        }
    }
}
