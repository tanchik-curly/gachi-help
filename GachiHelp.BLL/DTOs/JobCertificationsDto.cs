using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.DTOs;

public class JobCertificationDto
{
    public int Id { get; set; }

    public User CertificatedUser { get; set; }

    public int CertificatedUserId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }
}
