using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class User : IEntity
{
    public int Id { get; set; }

    public string Login { get; set; }

    public Role Role { get; set; }

    public string PasswordHash { get; set; }
}