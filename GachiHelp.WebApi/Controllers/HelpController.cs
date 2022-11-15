using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelpController : ControllerBase 
{
    private readonly IHelpService _helpService;

    public HelpController(IHelpService helpService)
    {
        _helpService = helpService;
    }

    [HttpGet]
    public ActionResult<PaginationList<HelpDto>> Get([FromQuery] int skip = 0, [FromQuery] int limit = -1)
    {
        return _helpService.GetHelp(skip: skip, limit: limit);
    }

    [HttpGet("{userId}")]        
    public ActionResult<PaginationList<HelpDto>> GetByUser(int userId, [FromQuery]int skip = 0, [FromQuery]int limit = -1)
    {
        return _helpService.GetHelp(userId, skip, limit);
    }
}