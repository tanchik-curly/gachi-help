using GachiHelp.BLL.DTOs;
using GachiHelp.DAL.Entities;

namespace GachiHelp.BLL.Services.Interfaces
{
    public interface IHelpService
    {
        IEnumerable<Help> GetHelpByUser(int userId, int skip = 0, int limit = -1);
        IEnumerable<HelpStatAggregateDto> GetUserHelpStatsByCategory(int userId, int? categoryId);
        IEnumerable<HelpStatAggregateDto> GetUserHelpStatsByPeriod(int userId, DateTime? from, DateTime? to);
    }
}
