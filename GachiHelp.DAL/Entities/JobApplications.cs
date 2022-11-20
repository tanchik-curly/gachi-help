using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class JobApplications : IEntity
{
    public int Id { get; set; }

    public JobApplicationsType ApplicationType { get; set; }

    public int ApplicationTypeId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public float Salary { get; set; }

    public ICollection<AppliedJobApplication>? AppliedJobApplication { get; set; }

    public ICollection<ProposedJobApplication>? ProposedJobApplication { get; set; }

    public DateTime CreatedAt { get; set; }
}
