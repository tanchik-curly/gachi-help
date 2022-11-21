using GachiHelp.BLL.DTOs;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IEmploymentService
{
    IEnumerable<JobApplicationDto> GetUserAppliedJobApplicationByPeriod(int userId, DateTime? from, DateTime? to);

    IEnumerable<JobApplicationDto> GetUserProposedJobApplicationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo);

    IEnumerable<JobCertificationDto> GetUserCertificationsByPeriod(int userId, DateTime? dateFrom, DateTime? dateTo, int skip = 0, int limit = -1);
}
