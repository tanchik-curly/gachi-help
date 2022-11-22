using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class EmploymentService : IEmploymentService
{
    private readonly IRepository<AppliedJobApplication> _employmentRepository;
    private readonly IRepository<ProposedJobApplication> _proposedApplicationRepository;
    private readonly IRepository<JobCertification> _certificationRepository;

    public EmploymentService(
        IRepository<AppliedJobApplication> employmentRepository,
        IRepository<ProposedJobApplication> proposedApplicationRepository,
        IRepository<JobCertification> certificationRepository
     )
    {
        _employmentRepository = employmentRepository;
        _proposedApplicationRepository = proposedApplicationRepository;
        _certificationRepository = certificationRepository;
    }

    public IEnumerable<JobApplications> GetUserAppliedJobApplicationByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo)
    {
        DateTime from = dateFrom ?? _employmentRepository.FindBy(appliedApplication => appliedApplication.AppliedUsersId == userId).Min(appliedApplication => appliedApplication.CreatedAt);
        DateTime to = dateTo ?? _employmentRepository.FindBy(appliedApplication => appliedApplication.AppliedUsersId == userId).Max(appliedApplication => appliedApplication.CreatedAt);
        
        Console.WriteLine("from: "+ from);
        Console.WriteLine("to: "+to);

        return _employmentRepository
            .FindIncluding(appliedApplication => (appliedApplication.AppliedUsersId == userId &&
                appliedApplication.CreatedAt >= from && appliedApplication.CreatedAt < to),
                appliedApplication => appliedApplication.JobApplication,
                appliedApplication => appliedApplication.JobApplication.ApplicationType)
            .Select(g => g.JobApplication);
    }

    public IEnumerable<JobApplications> GetUserProposedJobApplicationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo)
    {
        DateTime from = dateFrom ?? _proposedApplicationRepository.FindBy(proposedApplication => proposedApplication.UsersWithProposalId == userId).Min(proposedApplication => proposedApplication.CreatedAt);
        DateTime to = dateTo ?? _proposedApplicationRepository.FindBy(proposedApplication => proposedApplication.UsersWithProposalId == userId).Max(proposedApplication => proposedApplication.CreatedAt);
        
        Console.WriteLine("from: "+ from);
        Console.WriteLine("to: "+to);

        return _proposedApplicationRepository
            .FindIncluding(
            proposedApplication => proposedApplication.UsersWithProposalId == userId &&
                proposedApplication.CreatedAt >= from && proposedApplication.CreatedAt <= to,
                proposedApplication => proposedApplication.JobApplication,
                proposedApplication => proposedApplication.JobApplication.ApplicationType)
            .Select(g => g.JobApplication);
    }

    public IEnumerable<JobCertification> GetUserCertificationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo)
    {
        DateTime from = dateFrom ?? _certificationRepository.FindBy(certification => certification.CertificatedUserId == userId).Min(certification => certification.CreatedAt);
        DateTime to = dateTo ?? _certificationRepository.FindBy(certification => certification.CertificatedUserId == userId).Max(certification => certification.CreatedAt);

        Console.WriteLine("from: " + from);
        Console.WriteLine("to: " + to);

        return _certificationRepository
            .FindIncluding(
            certification => certification.CertificatedUserId == userId &&
                certification.CreatedAt >= from && certification.CreatedAt <= to)
            .ToList();
    }
}
