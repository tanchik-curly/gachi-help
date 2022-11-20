﻿using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StatController : ControllerBase
{
    private IStatService _statService;
    private IEmploymentService _employmentService;

    public StatController(
        IStatService statService,
        IEmploymentService employmentService
    )
    {
        _statService = statService;
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
}