using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelpController : ControllerBase 
{
    private readonly IHelpService _helpService;
    private readonly IMapper _mapper;

    public HelpController(IHelpService helpService, IMapper mapper)
    {
        _helpService = helpService;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<PaginationList<HelpDto>> Get(
        [FromQuery] int skip = 0, 
        [FromQuery] int limit = -1, 
        [FromQuery] DateTime from = default, 
        [FromQuery] DateTime to = default)
    {
        IEnumerable<Help> help = _helpService.GetHelp(from: from, to: to);

        return GeneratePaginationList(help, skip, limit);
    }

    [HttpGet("{userId}")]        
    public ActionResult<PaginationList<HelpDto>> GetByUser(int userId,
        [FromQuery] int skip = 0,
        [FromQuery] int limit = -1,
        [FromQuery] DateTime from = default,
        [FromQuery] DateTime to = default)
    {
        IEnumerable<Help> help = _helpService.GetHelp(userId, from, to);

        return GeneratePaginationList(help, skip, limit);
    }

    private PaginationList<HelpDto> GeneratePaginationList(IEnumerable<Help> help, int skip = 0, int limit = -1)
    {
        int count = help.Count();

        help = help.Skip(skip);

        if (limit != -1)
            help = help.Take(limit);

        return new PaginationList<HelpDto> { Items = help.Select(h => _mapper.Map<HelpDto>(h)), ItemCount = count };
    }
}