using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.DTOs;

public class HelpDto
{
    public int Id { get; set; }

    public HelpCategory? HelpCategory { get; set; }

    public UserDto? Author { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Status { get; set; } = null!;
}
