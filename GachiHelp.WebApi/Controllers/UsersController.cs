using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IUserService _userService;
    private IMapper _mapper;

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
}