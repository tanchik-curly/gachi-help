using AutoMapper;
using GachiHelp.BLL.DTOs;
using GachiHelp.BLL.Services.Interfaces;
using GachiHelp.DAL.Entities;
using GachiHelp.DAL.Repository;

namespace GachiHelp.BLL.Services
{
    public class HelpService : IHelpService
    {
        private readonly IRepository<Help> _helpRepository;
        private readonly IMapper _mapper;

        public HelpService(IRepository<Help> helpRepository, IMapper mapper)
        {
            _helpRepository = helpRepository;
            _mapper = mapper;
        }

        public PaginationList<HelpDto> GetHelp(int skip = 0, int limit = -1)
        {
            var helps = _helpRepository.AllIncluding(h => h.Author!, h => h.HelpCategory!);
            int count = helps.Count();
            helps = helps.OrderBy(h => h.CreatedAt).Skip(skip);
            helps = (limit == -1) ? helps : helps.Take(limit);
            return new PaginationList<HelpDto> { Items = helps.Select(h => _mapper.Map<HelpDto>(h)), ItemCount = count };
        }

        public PaginationList<HelpDto> GetHelpByUser(int userId, int skip = 0, int limit = -1)
        {
            var helps = _helpRepository.FindIncluding(h => h.AuthorId == userId, h => h.Author!, h => h.HelpCategory!);
            int count = helps.Count();
            helps = helps.OrderBy(h => h.CreatedAt).Skip(skip);
            helps = (limit == -1) ? helps : helps.Take(limit);
            return new PaginationList<HelpDto> { Items = helps.Select(h => _mapper.Map<HelpDto>(h)), ItemCount = count };
        }

        public IEnumerable<HelpStatAggregateDto> GetHelpStatsByCategory(int? categoryId)
        {
            return _helpRepository.FindBy(h => (categoryId == null || h.HelpCategoryId == categoryId))
                .GroupBy(h => h.Status).Select(g => new HelpStatAggregateDto { Group = g.Key.ToString("G"), Quantity = g.Count() });
        }

        public IEnumerable<HelpStatAggregateDto> GetHelpStatsByPeriod(DateTime? from, DateTime? to)
        {
            DateTime from2 = from ?? _helpRepository.GetAll().Min(u => u.CreatedAt);
            DateTime to2 = to ?? _helpRepository.GetAll().Max(u => u.CreatedAt);

            return _helpRepository.FindBy(h => h.CreatedAt >= from2 && h.CreatedAt <= to2)
                .GroupBy(h => h.CreatedAt.ToString("yyyy-MM-01T00:00:00"))
                .Select(g => new HelpStatAggregateDto { Group = g.Key, Quantity = g.Count() })
                .UnionBy(Enumerable.Range(0, (to2.Month - from2.Month) + 12 * (to2.Year - from2.Year) + 1)
                .Select(n => new HelpStatAggregateDto { Group = from2.AddMonths(n).ToString("yyyy-MM-01T00:00:00"), Quantity = 0 }),
                dto => dto.Group).OrderBy(dto => dto.Group);
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
