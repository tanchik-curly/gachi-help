using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class AppliedJobApplication : IEntity
{
    public int Id { get; set; }

    public int AppliedUsersId { get; set; }

    public User AppliedUser { get; set; }

    public int JobApplicationId { get; set; }

    public JobApplications JobApplication { get; set; }

    public DateTime CreatedAt { get; set; }
}
