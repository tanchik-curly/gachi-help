namespace GachiHelp.BLL.DTOs;

public class AuthDto
{
    public string Token { get; set; } = null!;
    public long ExpirationTime { get; set; }
    public int UserId { get; set; }
}
