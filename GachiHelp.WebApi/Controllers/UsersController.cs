using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UsersController(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<PaginationList<UserDto>> Get(int skip = 0, int limit = -1, string? searchQuery = "") 
    {
        return _userService.GetAll(skip, limit, searchQuery);
    }

    [HttpGet("{userId}")]
    public ActionResult<UserDetailDto?> Get(int userId)
    {
        User? user = _userService.GetUser(userId);
        if (user == null)
            return BadRequest();
        return _mapper.Map<UserDetailDto>(user);
    }

    [HttpGet("{userId}/comments")]
    public ActionResult<PaginationList<UserCommentDto>> GetUserComments(int userId, [FromQuery] int skip = 0, [FromQuery] int limit = -1)
    {
        var comments = _userService.GetUserComments(userId, skip, limit);
        var commentDtos = _mapper.Map<IEnumerable<UserCommentDto>>(comments);
        var result = new PaginationList<UserCommentDto>
        {
            Items = commentDtos,
            ItemCount = commentDtos.Count()
        };
        return result;
    }
}