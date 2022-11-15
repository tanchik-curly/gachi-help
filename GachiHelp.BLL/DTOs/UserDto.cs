namespace GachiHelp.BLL.DTOs;

public class UserDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronym { get; set; } = null!;
}
