using AutoMapper;
using LandingPage.API.Data;
using LandingPage.API.Models.Group;
using LandingPage.API.Models.Tenant;
using LandingPage.API.Models.User;

namespace LandingPage.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<GroupCreateDto, Group>().ReverseMap();
            CreateMap<GroupUpdateDto, Group>().ReverseMap();
            CreateMap<GroupReadOnlyDto, Group>().ReverseMap();

            CreateMap<TenantCreateDto, Tenant>().ReverseMap();
            CreateMap<TenantUpdateDto, Tenant>().ReverseMap();
            CreateMap<TenantReadOnlyDto, Tenant>().ReverseMap();

            CreateMap<ApplicationUser, UserDto>().ReverseMap();
            CreateMap<UserReadOnlyDto, ApplicationUser>().ReverseMap();

        }
    }
}
