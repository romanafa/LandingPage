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
            //Mapping for Group entity
            CreateMap<GroupCreateDto, Group>().ReverseMap();
            CreateMap<GroupUpdateDto, Group>().ReverseMap();
            CreateMap<GroupReadOnlyDto, Group>().ReverseMap();
            CreateMap<GroupDto, Group>().ReverseMap();

            //Mapping for Tenant entity
            CreateMap<TenantCreateDto, Tenant>().ReverseMap();
            CreateMap<TenantUpdateDto, Tenant>().ReverseMap();
            CreateMap<TenantReadOnlyDto, Tenant>().ReverseMap();
            CreateMap<TenantDto, Tenant>().ReverseMap();

            //Mapping for ApplicationUser entity
            CreateMap<ApplicationUser, UserCreateDto>().ReverseMap();
            CreateMap<ApplicationUser, LoginUserDto>().ReverseMap();
            CreateMap<UserReadOnlyDto, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUser, UserUpdateDto>().ReverseMap();

            //CreateMap<UserUpdateDto, ApplicationUser>()
            //    .ForMember(dest => dest.Roles,
            //    opt => opt.MapFrom(src => src.Roles))
            //    .ReverseMap();

            //CreateMap<ApplicationUser, UserUpdateDto>()
            //    .ForMember(dest => dest.Roles,
            //    opt => opt.MapFrom(src => src.UserRoles.Select(r => r.Role).ToList()))
            //    .ReverseMap();

            //Mapping for ApplicationRole entity
            CreateMap<RoleDto, ApplicationRole>().ReverseMap();
            CreateMap<RoleDto, ApplicationUserRole>().ReverseMap();
        }
    }
}
