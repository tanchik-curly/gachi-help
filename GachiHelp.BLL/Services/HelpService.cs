using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services
{
    public class HelpService : IHelpService
    {
        private readonly IRepository<Help> _helpRepository;

        public HelpService(IRepository<Help> helpRepository)
        {
            _helpRepository = helpRepository;
        }

        public IEnumerable<Help> GetHelpByUser(int userId, int skip = 0, int limit = -1)
        {
            var helps = _helpRepository.FindIncluding(h => h.AuthorId == userId, h => h.HelpCategory!)
                .OrderBy(h => h.CreatedAt).Skip(skip);
            return (limit == -1) ? helps : helps.Take(limit);
        }

        public IEnumerable<HelpStatAggregateDto> GetUserHelpStatsByCategory(int userId, int? categoryId)
        {
            return _helpRepository.FindBy(h => h.AuthorId == userId && (categoryId == null || h.HelpCategoryId == categoryId))
                .GroupBy(h=>h.Status).Select(g=>new HelpStatAggregateDto { Group = g.Key.ToString("G"), Quantity=g.Count() });
        }

        public IEnumerable<HelpStatAggregateDto> GetUserHelpStatsByPeriod(int userId, DateTime? from, DateTime? to)
        {
            DateTime from2 = from ?? _helpRepository.FindBy(h => h.AuthorId == userId).Min(u => u.CreatedAt);
            DateTime to2 = to ?? _helpRepository.FindBy(h => h.AuthorId == userId).Max(u => u.CreatedAt);

            return _helpRepository.FindBy(h => h.AuthorId == userId && h.CreatedAt >= from2 && h.CreatedAt <= to2)
                .GroupBy(h => h.CreatedAt.ToString("yyyy-MM-01T00:00:00"))
                .Select(g => new HelpStatAggregateDto { Group = g.Key, Quantity = g.Count() })
                .UnionBy(Enumerable.Range(0, (to2.Month - from2.Month) + 12 * (to2.Year - from2.Year) + 1)
                .Select(n => new HelpStatAggregateDto { Group = from2.AddMonths(n).ToString("yyyy-MM-01T00:00:00"), Quantity = 0 }),
                dto => dto.Group).OrderBy(dto => dto.Group);
        }
    }
}
