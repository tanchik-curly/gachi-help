using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class EmploymentService : IEmploymentService
{
    private readonly IRepository<AppliedJobApplication> _employmentRepository;
    private readonly IRepository<ProposedJobApplication> _proposedApplicationRepository;
    private readonly IMapper _mapper;

    public EmploymentService(
        IRepository<AppliedJobApplication> employmentRepository,
        IRepository<ProposedJobApplication> proposedApplicationRepository,
        IMapper mapper
     )
    {
        _employmentRepository = employmentRepository;
        _proposedApplicationRepository = proposedApplicationRepository;
        _mapper = mapper;
    }

    public IEnumerable<JobApplicationDto> GetUserAppliedJobApplicationByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo)
    {
        DateTime from = dateFrom ?? _employmentRepository.FindBy(appliedApplication => appliedApplication.AppliedUsersId == userId).Min(appliedApplication => appliedApplication.CreatedAt);
        DateTime to = dateTo ?? _employmentRepository.FindBy(appliedApplication => appliedApplication.AppliedUsersId == userId).Max(appliedApplication => appliedApplication.CreatedAt);
        
        Console.WriteLine("from: "+ from);
        Console.WriteLine("to: "+to);

        return _employmentRepository
            .FindIncluding(appliedApplication => appliedApplication.AppliedUsersId == userId &&
                appliedApplication.CreatedAt >= from && appliedApplication.CreatedAt <= to,
                appliedApplication => appliedApplication.JobApplication,
                appliedApplication => appliedApplication.JobApplication.ApplicationType)
            .Select(g => _mapper.Map<JobApplicationDto>(g.JobApplication));
    }

    public IEnumerable<JobApplicationDto> GetUserProposedJobApplicationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo)
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
            .Select(g => _mapper.Map<JobApplicationDto>(g.JobApplication));
    }
}
