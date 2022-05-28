using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public interface IGroupService
    {
        Task<Response<List<GroupReadOnlyDto>>> GetGroups();
        Task<Response<GroupReadOnlyDto>> Get(int id);
        Task<Response<int>> Create(GroupCreateDto group);
        Task<Response<int>> Edit(int id, GroupUpdateDto group);
        Task<Response<GroupUpdateDto>> GetForUpdate(int id);
        Task<Response<int>> Delete(int id);
    }
}
