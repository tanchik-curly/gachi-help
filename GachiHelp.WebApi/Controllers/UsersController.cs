using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IRepository<User> _userRepository;
    private readonly IMapper _mapper;

    public UsersController(IRepository<User> userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<UserDto>> Index() 
    {
        return _userRepository.AllIncluding().Select(u => _mapper.Map<UserDto>(u))
            .OrderBy(u=>u.Surname).ThenBy(u=>u.Name).ThenBy(u=>u.Patronym).ToArray();
    }

    [HttpGet("{userId}")]
    public ActionResult<UserDetailDto?> Detail(int userId)
    {
        return _mapper.Map<UserDetailDto>(_userRepository.GetSingle(userId));
    }
}