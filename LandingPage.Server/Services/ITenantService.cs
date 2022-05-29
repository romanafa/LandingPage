using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public interface ITenantService
    {
        Task<Response<List<TenantReadOnlyDto>>> GetTenants();
        Task<Response<List<TenantReadOnlyDto>>> GetTenantsWithGroups();
        Task<Response<TenantReadOnlyDto>> Get(int id);
        Task<Response<int>> Create(TenantCreateDto tenant);
        Task<Response<int>> Edit(int id, TenantUpdateDto tenant);
        Task<Response<TenantUpdateDto>> GetForUpdate(int id);
        Task<Response<int>> Delete(int id);
    }
}
