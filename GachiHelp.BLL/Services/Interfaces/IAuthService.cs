using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GachiHelp.BLL.DTOs.User;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        AuthDto GetAuthData(User user);
        string HashPassword(string password);
        bool VerifyPassword(string actualPassword, string hashedPassword);
    }
}
