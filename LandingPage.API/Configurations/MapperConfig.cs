using AutoMapper;
using LandingPage.API.Data;
using LandingPage.API.Models.Group;

namespace LandingPage.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<GroupCreateDto, Group>().ReverseMap();
            CreateMap<GroupUpdateDto, Group>().ReverseMap();
            CreateMap<GroupReadOnlyDto, Group>().ReverseMap();
        }
    }
}
