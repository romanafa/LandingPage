using AutoMapper;
using LandingPage.Server.Services.Base;

namespace LandingPage.Server.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<GroupReadOnlyDto, GroupUpdateDto>().ReverseMap();
            CreateMap<TenantReadOnlyDto, TenantUpdateDto>().ReverseMap();
            CreateMap<UserReadOnlyDto, UserUpdateDto>().ReverseMap();
        }
    }
}
