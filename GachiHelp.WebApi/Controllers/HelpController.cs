using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("Requested-help")]
public class HelpController : ControllerBase 
{
    private readonly IHelpService _helpService;

    public HelpController(IHelpService helpService)
    {
        _helpService = helpService;
    }

    [HttpGet]
    public ActionResult<PaginationList<HelpDto>> Get([FromQuery] int? skip, [FromQuery] int? limit)
    {
        return _helpService.GetHelp(skip: skip ?? 0, limit: limit ?? -1);
    }

    [HttpGet("{userId}")]        
    public ActionResult<PaginationList<HelpDto>> GetByUser(int userId, [FromQuery]int? skip, [FromQuery]int? limit)
    {
        return _helpService.GetHelp(userId, skip ?? 0, limit ?? -1);
    }
}