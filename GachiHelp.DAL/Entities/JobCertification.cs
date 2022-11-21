using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class JobCertification : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public User CertificatedUser { get; set; }

    public int CertificatedUserId { get; set; }
}
