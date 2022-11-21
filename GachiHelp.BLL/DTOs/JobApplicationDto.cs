using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.DTOs;

public class JobApplicationDto
{
    public int Id { get; set; }

    public JobApplicationsType ApplicationType { get; set; }

    public int ApplicationTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public float Salary { get; set; }

    public DateTime CreatedAt { get; set; }
}
