using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using GachiHelp.BLL.DTOs.User;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using Microsoft.IdentityModel.Tokens;

namespace GachiHelp.BLL.Services;

public class AuthService : IAuthService
{
    private readonly long _jwtLifespan;
    private readonly string _jwtSecret;

    public AuthService(long jwtLifespan, string jwtSecret)
    {
        _jwtLifespan = jwtLifespan;
        _jwtSecret = jwtSecret;
    }

    public AuthData GetAuthData(User user)
    {
        var expirationTime = DateTime.UtcNow.AddSeconds(_jwtLifespan);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim("login", user.Login),
                new Claim("name", user.Name),
                new Claim("surname", user.Surname),
                new Claim("patronym", user.Patronym),
                new Claim(ClaimTypes.Role, user.Role.ToString("G")),
            }),
            Expires = expirationTime,
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSecret)),
                SecurityAlgorithms.HmacSha256Signature
            )
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

        return new AuthData
        {
            Token = token,
            ExpirationTime = ((DateTimeOffset)expirationTime).ToUnixTimeSeconds(),
            UserId = user.Id
        };
    }

    public string HashPassword(string password) =>
        Convert.ToBase64String(SHA256.HashData(Encoding.Default.GetBytes(password)));

    public bool VerifyPassword(string actualPassword, string hashedPassword) =>
        Compare(SHA256.HashData(Encoding.Default.GetBytes(actualPassword)),
            Convert.FromBase64String(hashedPassword));

    private static bool Compare(ReadOnlySpan<byte> a, ReadOnlySpan<byte> b)

    {

        int x = a.Length ^ b.Length;

        for (int i = 0; i < a.Length && i < b.Length; ++i)

        {

            x |= a[i] ^ b[i];

        }
        return x == 0;
    }
}