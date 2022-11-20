using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StatController : ControllerBase
{
    private readonly IStatService _statService;
    private readonly IMapper _mapper;

    public StatController(IStatService statService, IMapper mapper)
    {
        _statService = statService;
        _mapper = mapper;
    }

    [HttpGet("help-requests")]
    public ActionResult<IEnumerable<HelpStatAggregateDto>> GetHelpStats([FromQuery] string by, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int? categoryId)
    {
        return by switch
        {
            "period" => _statService.GetHelpStatsByPeriod(null, from, to).ToArray(),
            "category" => _statService.GetHelpStatsByCategory(null, categoryId).ToArray(),
            _ => BadRequest()
        };
    }

    [HttpGet("{userId}/help-requests")]
    public ActionResult<IEnumerable<HelpStatAggregateDto>> GetUsersHelpStats(int userId, [FromQuery] string by, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int? categoryId)
    {
        return by switch
        {
            "period" => _statService.GetHelpStatsByPeriod(userId, from, to).ToArray(),
            "category" => _statService.GetHelpStatsByCategory(userId, categoryId).ToArray(),
            _ => BadRequest()
        };
    }

    [HttpGet("{userId}/social-stats")]
    public ActionResult<SocialStatsDto> GetUserSocialStats(int userId)
    {
        var stats = _statService.GetUserSocialStats(userId);
        return _mapper.Map<SocialStatsDto>(stats);
    }
}