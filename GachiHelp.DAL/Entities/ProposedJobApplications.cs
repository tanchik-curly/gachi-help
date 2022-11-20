using GachiHelp.DAL.Enums;

namespace GachiHelp.DAL.Entities;

public class ProposedJobApplication : IEntity
{
    public int Id { get; set; }

    public int UsersWithProposalId { get; set; }

    public User UsersWithProposal { get; set; }

    public int JobApplicationId { get; set; }

    public JobApplications JobApplication { get; set; }

    public DateTime CreatedAt { get; set; }
}
