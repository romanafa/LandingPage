using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public interface IUserService
    {
        Task<Response<List<UserReadOnlyDto>>> GetUsers();
        Task<Response<UserReadOnlyDto>> Get(string id);
        Task<Response<int>> Create(UserCreateDto user);
        Task<Response<int>> Edit(string id, UserUpdateDto user);
        Task<Response<UserUpdateDto>> GetForUpdate(string id);
        Task<Response<int>> Delete(string id);
        Task<Response<List<RoleDto>>> GetAllRoles();
    }
}
