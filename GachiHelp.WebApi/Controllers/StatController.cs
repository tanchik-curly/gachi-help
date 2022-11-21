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
    private readonly IEmploymentService _employmentService;

    public StatController(
        IStatService statService, 
        IMapper mapper,
        IEmploymentService employmentService
    )
    {
        _statService = statService;
        _mapper = mapper;
        _employmentService = employmentService;
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
        Console.WriteLine("userId help", userId);

        return by switch
        {
            "period" => _statService.GetHelpStatsByPeriod(userId, from, to).ToArray(),
            "category" => _statService.GetHelpStatsByCategory(userId, categoryId).ToArray(),
            _ => BadRequest()
        };
    }

    [HttpGet("{userId}/job-applications")]
    public ActionResult<IEnumerable<JobApplicationDto>> GetAppliedJobApplications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to)
    {
        return _employmentService.GetUserAppliedJobApplicationByPeriod(userId, from, to).ToArray();
    }

    [HttpGet("{userId}/proposed-job-applications")]
    public ActionResult<IEnumerable<JobApplicationDto>> GetProposedJobApplications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to)
    {
        return _employmentService.GetUserProposedJobApplicationsByPeriod(userId, from, to).ToArray();
    }

    [HttpGet("{userId}/certifications")]
    public ActionResult<IEnumerable<JobCertificationDto>> GetUserCertifications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int skip = 0, [FromQuery] int limit = -1)
    {
        return _employmentService.GetUserCertificationsByPeriod(userId, from, to, skip, limit).ToArray();
    }

    [HttpGet("{userId}/social-stats")]
    public ActionResult<SocialStatsDto> GetUserSocialStats(int userId)
    {
        var stats = _statService.GetUserSocialStats(userId);
        return _mapper.Map<SocialStatsDto>(stats);
    }
}