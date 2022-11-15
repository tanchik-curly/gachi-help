using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;
using GachiHelp.WebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GachiHelp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IRepository<User> _userRepository;

    public AuthController(IAuthService authService, IRepository<User> userRepository)
    {
        _authService = authService;
        _userRepository = userRepository;
    }

    [HttpPost("login")]
    public ActionResult<AuthDto> Post([FromBody] LoginViewModel model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = _userRepository.GetSingle(u => u.Login == model.Login);

        if (user == null)
        {
            return BadRequest(new { email = "no user with this email" });
        }

        var passwordValid = _authService.VerifyPassword(model.Password ?? "", user.PasswordHash);
        if (!passwordValid)
        {
            return BadRequest(new { password = "invalid password" });
        }

        return _authService.GetAuthData(user);
    }
}