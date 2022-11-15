using GachiHelp.DAL.Enums;

namespace GachiHelp.BLL.DTOs;

public class UserDetailDto
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronym { get; set; } = null!;
}
