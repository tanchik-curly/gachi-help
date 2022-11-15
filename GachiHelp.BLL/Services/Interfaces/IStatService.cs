using GachiHelp.BLL.DTOs;

namespace GachiHelp.BLL.Services.Interfaces;

public interface IStatService
{
    IEnumerable<HelpStatAggregateDto> GetHelpStatsByCategory(int? userId, int? categoryId);
    IEnumerable<HelpStatAggregateDto> GetHelpStatsByPeriod(int? userId, DateTime? from, DateTime? to);
}
