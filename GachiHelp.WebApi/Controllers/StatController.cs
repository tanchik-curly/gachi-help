using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StatController : ControllerBase
{
    private IStatService _statService;

    public StatController(IStatService statService)
    {
        _statService = statService;
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
}