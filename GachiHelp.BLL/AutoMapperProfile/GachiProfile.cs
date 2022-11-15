using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.AutoMapperProfile;

public class GachiProfile : Profile
{
    public GachiProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Help, HelpDto>();
    }
}
