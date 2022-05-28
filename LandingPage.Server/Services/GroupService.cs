using AutoMapper;
using Blazored.LocalStorage;
using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Services
{
    public class GroupService : BaseHttpService, IGroupService
    {
        private readonly IClient client;
        private readonly IMapper mapper;

        public GroupService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            this.client = client;
            this.mapper = mapper;
        }

        public async Task<Response<List<GroupReadOnlyDto>>> GetGroups()
        {
            Response<List<GroupReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.GroupsAllAsync();
                response = new Response<List<GroupReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<GroupReadOnlyDto>>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Create(GroupCreateDto group)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.GroupsPOSTAsync(group);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Edit(int id, GroupUpdateDto group)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.GroupsPUTAsync(id, group);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }

        public async Task<Response<GroupReadOnlyDto>> Get(int id)
        {
            Response<GroupReadOnlyDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.GroupsGETAsync(id);
                response = new Response<GroupReadOnlyDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<GroupReadOnlyDto>(exception);
            }

            return response;
        }

        public async Task<Response<GroupUpdateDto>> GetForUpdate(int id)
        {
            Response<GroupUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.GroupsGETAsync(id);
                response = new Response<GroupUpdateDto>
                {
                    Data = mapper.Map<GroupUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<GroupUpdateDto>(exception);
            }

            return response;
        }

        public async Task<Response<int>> Delete(int id)
        {
            Response<int> response = new();

            try
            {
                await GetBearerToken();
                await client.GroupsDELETEAsync(id);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }

            return response;
        }
    }
}
