using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class Help : IEntity
{
    public int Id { get; set; }

    public HelpCategory? HelpCategory { get; set; }

    public int HelpCategoryId { get; set; }

    public User? Author { get; set; }

    public int AuthorId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DocumentStatus Status { get; set; } 
}
