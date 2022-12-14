using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    public ActionResult<PaginationList<JobApplicationDto>> GetAppliedJobApplications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int skip = 0, [FromQuery] int limit = -1)
    {
        IEnumerable<JobApplications> applications = _employmentService.GetUserAppliedJobApplicationByPeriod(userId, from, to).ToArray();
        return GenerateApplicationnPaginationList(applications, skip, limit);
    }

    [HttpGet("{userId}/proposed-job-applications")]
    public ActionResult<IEnumerable<JobApplicationDto>> GetProposedJobApplications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to)
    {
        IEnumerable<JobApplications> applications = _employmentService.GetUserProposedJobApplicationsByPeriod(userId, from, to).ToArray();
        return applications.Select(app => _mapper.Map<JobApplicationDto>(app)).ToList();
    }

    [HttpGet("{userId}/certifications")]
    public ActionResult<PaginationList<JobCertificationDto>> GetUserCertifications(int userId, [FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] int skip = 0, [FromQuery] int limit = -1)
    {
        IEnumerable<JobCertification> certifications = _employmentService.GetUserCertificationsByPeriod(userId, from, to).ToArray();
        return GenerateCertificationPaginationList(certifications, skip, limit);
    }

    [HttpGet("{userId}/social-stats")]
    public ActionResult<SocialStatsDto> GetUserSocialStats(int userId)
    {
        var stats = _statService.GetUserSocialStats(userId);
        return _mapper.Map<SocialStatsDto>(stats);
    }

    private PaginationList<JobCertificationDto> GenerateCertificationPaginationList(IEnumerable<JobCertification> certifications, int skip, int limit)
    {
        int count = certifications.Count();

        certifications = certifications.Skip(skip);

        if (limit != -1)
        {
            certifications = certifications.Take(limit);
        }

        return new PaginationList<JobCertificationDto> { Items = certifications.Select(h => _mapper.Map<JobCertificationDto>(h)), ItemCount = count };
    }

    private PaginationList<JobApplicationDto> GenerateApplicationnPaginationList(IEnumerable<JobApplications> applications, int skip, int limit)
    {
        int count = applications.Count();

        applications = applications.Skip(skip);

        if (limit != -1)
        {
            applications = applications.Take(limit);
        }

        return new PaginationList<JobApplicationDto> { Items = applications.Select(h => _mapper.Map<JobApplicationDto>(h)), ItemCount = count };
    }
}