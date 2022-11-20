using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.AutoMapperProfile;

public class GachiProfile : Profile
{
    public GachiProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<User, UserDetailDto>();
        CreateMap<Help, HelpDto>();
        CreateMap<UserComment, UserCommentDto>();
        CreateMap<UserSocialStats, SocialStatsDto>();
    }
}
