namespace GachiHelp.DAL.Entities;

public class HelpCategory : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
