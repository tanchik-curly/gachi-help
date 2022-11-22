using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class HelpService : IHelpService
{
    private readonly IRepository<Help> _helpRepository;

    public HelpService(IRepository<Help> helpRepository)
    {
        _helpRepository = helpRepository;
    }

    public IEnumerable<Help> GetHelp(int userId = -1, DateTime from = default, DateTime to = default)
    {
        var help = _helpRepository.FindIncluding(
            h => (from == default || h.CreatedAt > from) 
                && (to == default || h.CreatedAt <= to), 
            h => h.Author!, h => 
            h.HelpCategory!);

        if (userId != -1)
            help = help.Where(h => h.AuthorId == userId);

        return help.OrderByDescending(h => h.CreatedAt);
    }
}
