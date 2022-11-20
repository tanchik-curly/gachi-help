using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services;

public class StatService : IStatService
{
    private readonly IRepository<Help> _helpRepository;
    private readonly IRepository<UserSocialStats> _userSocialStatsRepository;

    public StatService(IRepository<Help> helpRepository, IRepository<UserSocialStats> userSocialStatsRepository)
    {
        _helpRepository = helpRepository;
        _userSocialStatsRepository = userSocialStatsRepository;
    }

    public IEnumerable<HelpStatAggregateDto> GetHelpStatsByCategory(int? userId, int? categoryId)
    {
        return _helpRepository
            .FindBy(h => (userId == null || h.AuthorId == userId) &&
                (categoryId == null || h.HelpCategoryId == categoryId))
            .GroupBy(h => h.Status)
            .Select(g => new HelpStatAggregateDto { Group = g.Key.ToString("G"), Quantity = g.Count() });
    }

    public IEnumerable<HelpStatAggregateDto> GetHelpStatsByPeriod(int? userId, DateTime? from, DateTime? to)
    {
        string specialVeryImportantDateFormat = "yyyy-MM-01T00:00:00";

        DateTime from2 = from ?? _helpRepository.FindBy(h => userId == null || h.AuthorId == userId).Min(u => u.CreatedAt);
        DateTime to2 = to ?? _helpRepository.FindBy(h => userId == null || h.AuthorId == userId).Max(u => u.CreatedAt);

        return _helpRepository
            .FindBy(h => (userId == null || h.AuthorId == userId) && h.CreatedAt >= from2 && h.CreatedAt <= to2)
            .GroupBy(h => h.CreatedAt.ToString(specialVeryImportantDateFormat))
            .Select(g => new HelpStatAggregateDto { Group = g.Key, Quantity = g.Count() })
            .UnionBy(
                Enumerable.Range(0, (to2.Month - from2.Month) + 12 * (to2.Year - from2.Year) + 1)
                    .Select(n => new HelpStatAggregateDto { Group = from2.AddMonths(n).ToString(specialVeryImportantDateFormat), Quantity = 0 }),
                dto => dto.Group).OrderBy(dto => dto.Group
            );
    }

    public UserSocialStats GetUserSocialStats(int userId)
    {
        return _userSocialStatsRepository.GetSingle(s => s.User.Id == userId);
    }
}
