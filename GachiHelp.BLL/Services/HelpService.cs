using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class HelpService : IHelpService
{
    private readonly IRepository<Help> _helpRepository;
    private readonly IMapper _mapper;

    public HelpService(IRepository<Help> helpRepository, IMapper mapper)
    {
        _helpRepository = helpRepository;
        _mapper = mapper;
    }

    public PaginationList<HelpDto> GetHelp(int userId = -1, int skip = 0, int limit = -1)
    {
        var help = _helpRepository.AllIncluding(h => h.Author!, h => h.HelpCategory!);

        if (userId != -1)
            help = help.Where(h => h.AuthorId == userId);

        int count = help.Count();

        help = help.OrderBy(h => h.CreatedAt).Skip(skip);

        if (limit != -1) 
            help = help.Take(limit);

        return new PaginationList<HelpDto> {
            Items = help.Select(h => _mapper.Map<HelpDto>(h)),
            ItemCount = count
        };
    }
}
