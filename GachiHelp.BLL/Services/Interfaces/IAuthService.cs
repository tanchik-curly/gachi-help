using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IAuthService
{
    AuthDto GetAuthData(User user);
    string HashPassword(string password);
    bool VerifyPassword(string actualPassword, string hashedPassword);
}
