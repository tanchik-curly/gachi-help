using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class User : IEntity
{
    public int Id { get; set; }

    public string Login { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Role Role { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Patronym { get; set; } = null!;

    public ICollection<AppliedJobApplication> AppliedJobApplication { get; set; }

    public ICollection<ProposedJobApplication> ProposedJobApplication { get; set; }
}