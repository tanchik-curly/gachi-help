using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IEmploymentService
{
    IEnumerable<JobApplications> GetUserAppliedJobApplicationByPeriod(int userId, DateTime? from, DateTime? to);

    IEnumerable<JobApplications> GetUserProposedJobApplicationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo);

    IEnumerable<JobCertification> GetUserCertificationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo);
}
